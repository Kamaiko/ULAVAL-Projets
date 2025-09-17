/* encryption */
let pem = localStorage.getItem("pem");
function getKeyPair() {
    // generer et sauvegarder la clef privee en format PEM dans localStorage
    let keyPair, privateKey, publicKey
    if (pem) {
        privateKey = forge.pki.privateKeyFromPem(pem);
        publicKey = forge.pki.setRsaPublicKey(privateKey.n, privateKey.e);
        keyPair = {privateKey, publicKey};
    } else {
        keyPair = forge.pki.rsa.generateKeyPair({bits: 1024});
        localStorage.setItem("pem", forge.pki.privateKeyToPem(keyPair.privateKey));
    };
    return keyPair;
};
let keyPair = getKeyPair();
let publicKeyPem = forge.pki.publicKeyToPem(keyPair.publicKey);
document.getElementById("publicKey").innerHTML = publicKeyPem;

/* APIs */
const urlGetLetters = 'http://localhost:3000/getLetters',
    urlAddLetter = 'http://localhost:3000/addLetter';


function decryptMsg(msg) {
    let decryptedMsg = forge.util.decodeUtf8(keyPair.privateKey.decrypt(forge.util.decode64(msg)));
    return decryptedMsg;
}

async function getMessagesFromServer() {
    fetch(urlGetLetters).then((data) => { 
        console.log(data);
        let arrayEncryptedMsg = Object.getOwnPropertyNames(data);
        let arrayDecryptedMsg = [];
        arrayEncryptedMsg.forEach(element => {
            try {
                arrayDecryptedMsg.push(decryptMsg(element));
            } catch (error) {
                console.log(`Could not decrypt message ${element}`);
            }
        });
        return arrayDecryptedMsg;
    }).then((res) => {
        console.log(res);
    });
};

async function postEncryptedMsg(data) {
    const response = await fetch(urlAddLetter, {
        method: 'POST',
        headers: {
            'Content-Type': 'text/plain'
        },
        body: data
    });

    console.log(data);
    console.log(response);
    refreshMsg();
    return response.json;
};



function viewSection(sectionID) {
    let sections = document.getElementsByClassName("nav-section");

    for (let i = 0; i < sections.length; i++) {
        if (sections[i].id == sectionID && sections[i].classList.contains("hidden")) {
            sections[i].classList.remove("hidden");
        }
        if (sections[i].id !== sectionID && !sections[i].classList.contains("hidden")) {
            sections[i].classList.add("hidden");
        }
    }
}

/*use this later
let btnEncrypt = document.getElementById('encrypt');
let btnDecrypt = document.getElementById('decrypt');

btnEncrypt.addEventListener("click", event => {
    let msg = document.getElementById("msg").value;
    try {
        document.querySelector(".result").innerText =
        forge.util.encode64( keyPair.publicKey.encrypt(forge.util.encodeUtf8(msg)));
    } catch (err) {
        document.querySelector(".result").innerText = err;
    };
});

btnDecrypt.addEventListener("click", event => {
    let msg = document.getElementById("msg").value;
    try {
        document.querySelector(".result").innerText =
        forge.util.decodeUtf8( keyPair.privateKey.decrypt(forge.util.decode64(msg)));
    } catch (err) {
        document.querySelector(".result").innerText = err;
    };
});
*/

/* contacts */

let arrayContacts = [];
let counterContacts;

//get data from localstorage or create if not exists
//turn into falsey statement?
if (localStorage.getItem("counterContacts") == null) {
    counterContacts = 0;
    localStorage.setItem("counterContacts", counterContacts);
} else {
    counterContacts = localStorage.getItem("counterContacts");
}

if (localStorage.getItem("arrayContacts") == "" || localStorage.getItem("arrayContacts") == null) {
    localStorage.setItem("arrayContacts", arrayContacts);
} else {
    arrayContacts = JSON.parse(localStorage.getItem("arrayContacts"));
}

function saveContact() {
    let frmID = document.getElementById("contactID").value;
    let frmName = document.getElementById("contactName").value;
    let frmPublicKey = document.getElementById("contactPublicKey").value; //document.forms["frmContacts"]["contactPublicKey"].value;

    if (frmName == "" || frmPublicKey == "") {
        alert("Erreur! Saisissez les données.");
    } else {
        let newID;
        if (frmID == "") {
            newID = ++counterContacts;
        } else {
            newID = frmID;
        }
    
        let frmNewContact = {
            "ID": newID,
            "name": frmName,
            "publicKey": frmPublicKey,
            "lastUpdate": new Date()
        };
    
        arrayContactsIndex = getArrayContactsIndexFromID(frmNewContact.ID);
    
        if (arrayContactsIndex == -1) {
            arrayContacts.push(frmNewContact);
        } else {
            arrayContacts[arrayContactsIndex] = frmNewContact;
        }
    
        fillContactForm("", "", "");
    }

    refreshContacts();
    refreshMsgContacts();
}

function getArrayContactsIndexFromID(newContactID) {
    for (var i = 0; i < arrayContacts.length; i++) {
        if (arrayContacts[i].ID == newContactID) {
            return i;
        }
    }
    return -1;
}

function fillContactForm(ID, name, publicKey) {
    let frmContactID = document.getElementById("contactID");
    let frmContactName = document.getElementById("contactName");
    let frmContactPublicKey = document.getElementById("contactPublicKey"); //document.forms["frmContacts"]["contactPublicKey"];

    frmContactID.value = ID;
    frmContactName.value = name;
    frmContactPublicKey.value = publicKey;
}

function addContactTableRow(newContact) {
    var tbodyRef = document.getElementById("tblContacts").getElementsByTagName("tbody")[0];
    var newRow = tbodyRef.insertRow();
    var cellID = newRow.insertCell(0);
    var cellName = newRow.insertCell(1);
    var cellPublicKey = newRow.insertCell(2);
    var cellLastUpdate = newRow.insertCell(3);
    var cellModify = newRow.insertCell(4);

    if (newContact == undefined) {
        cellName.innerHTML = "Aucun record";
    } else {
        cellID.innerHTML = newContact.ID;
        cellName.innerHTML = newContact.name;
        cellPublicKey.innerHTML = newContact.publicKey.replace(/\n/g,"<br>");
    
        //let lastUpdate = Date.parse(lastUpdate);
        let offset = newContact.lastUpdate.getTimezoneOffset();
        let lastUpdate = new Date(newContact.lastUpdate.getTime() - (offset * 60 * 1000));
        cellLastUpdate.innerHTML = lastUpdate.toISOString().replace("T"," ").substring(0,16).replace(":", " h ");

        let btnEdit = document.createElement("input");
        btnEdit.type = "submit";
        //btnEdit.className = "btn";
        btnEdit.value = "Modifier";
        btnEdit.id = "editContact" + newContact.ID;
        btnEdit.classList.add("button-margin");
        //btnEdit.onclick = function() {editContact(newContact.ID);}
        btnEdit.addEventListener("click", function() {
            editContact(newContact.ID);
        })
        cellModify.appendChild(btnEdit);

        let btnDelete = document.createElement("input");
        btnDelete.type = "button";
        //btnDelete.className = "btn";
        btnDelete.value = "Supprimer";
        btnDelete.id = "deleteContact" + newContact.ID;
        btnDelete.classList.add("button-margin");
        //btnDelete.onclick = function() {deleteContact(newContact.ID);}
        btnDelete.addEventListener("click", function() {
            deleteContact(newContact.ID);
        })
        cellModify.appendChild(btnDelete);
    }
}

function refreshContacts(searchCond) {
    let contactsTable = document.getElementById("tblContactsBody");
    contactsTable.innerHTML = "";

    if (arrayContacts.length === 0) {
        addContactTableRow();
    } else {
        for (var i = 0; i < arrayContacts.length; i++) {
            arrayContacts[i].lastUpdate = new Date(arrayContacts[i].lastUpdate);
            if (searchCond == undefined || JSON.stringify(arrayContacts[i]).includes(searchCond)) {
                addContactTableRow(arrayContacts[i]);
            }
        }
    }

    localStorage.setItem("arrayContacts", JSON.stringify(arrayContacts));
    localStorage.setItem("counterContacts", counterContacts);
}

function editContact(contactIDToEdit) {
    let contactToEdit;

    for (let i = 0; i < arrayContacts.length; i++) {
        if (arrayContacts[i].ID == contactIDToEdit) {
            contactToEdit = arrayContacts[i];
            fillContactForm(contactToEdit.ID, contactToEdit.name, contactToEdit.publicKey);
            break;
        }
    }

    refreshContacts();
}

function deleteContact(contactIDToDelete) {
    let contactIndexToDelete;
    for (let i = 0; i < arrayContacts.length; i++) {
        if (arrayContacts[i].ID == contactIDToDelete) {
            contactIndexToDelete = i;
            arrayContacts.splice(contactIndexToDelete);
            break;
        }
    }
    refreshContacts();     
}

function refreshMsgContacts() {
    let msgContact = document.getElementById("msgContact");
    msgContact.innerHTML = "";
    for (let i = -1; i < arrayContacts.length; i++) {
        let opt = document.createElement("option");
        if (i == -1) {
            if (arrayContacts.length === 0) {
                opt.innerText = "Aucun contact";
            } else {
                opt.innerText = "Choisir contact";
            }
            opt.value = "blankrow";
        } else {
            opt.innerText = arrayContacts[i].name;
            opt.value = arrayContacts[i].ID;
            opt.name = arrayContacts[i].name;
        }
        msgContact.appendChild(opt);
    }
}


/* messages */

let arrayMsg = []
let counterMsg = 0;

function sendMsg() {
    let frmMsgContactID = document.getElementById("msgContact").value;
    let frmMsgText = document.getElementById("msgText").value;

    if (frmMsgContactID == "blankrow") {
        alert("Erreur! Choisissez un contact.");
    } else if (frmMsgText == "") { 
        alert("Erreur! Saisissez le message.");
    } else {
        let contactIndex = getArrayContactsIndexFromID(frmMsgContactID);
        let contact = arrayContacts[contactIndex];
        let msgEncrypted;
        try {
            console.log(contact.publicKey); /* Console.log la même chose que console.log(forge.pki.publicKeyToPem(contactPublicKey)); */
            let contactPublicKey = forge.pki.publicKeyFromPem(contact.publicKey);
            console.log(forge.pki.publicKeyToPem(contactPublicKey));
            msgEncrypted = forge.util.encode64(contactPublicKey.encrypt(forge.util.encodeUtf8(frmMsgText)));
            postEncryptedMsg(msgEncrypted);
        } catch (err) {
            console.log(err);
        };
    }
}

function refreshMsg(searchCond) {
    arrayMsg = [];
    let arrayDecryptedMsg = getMessagesFromServer();

    let msgTable = document.getElementById("tblMsgBody");
    msgTable.innerHTML = "";

    if (arrayMsg.length === 0) {
        addMsgTableRow();
    } else {
        for (let i = 0; i < arrayDecryptedMsg.length; i++) {
            let newMsg = {
                "ID": ++counterMsg,
                "message": arrayDecryptedMsg[i],
                "lastUpdate": new Date()
            };
            arrayMsg.push(newMsg);
            if (searchCond == undefined || arrayDecryptedMsg[i].includes(searchCond)) {
                addMsgTableRow(newMsg);
            }
        };
    }
}

function addMsgTableRow(newMsg) {
    let tbodyRef = document.getElementById("tblMsg").getElementsByTagName("tbody")[0];
    let newRow = tbodyRef.insertRow();
    let cellID = newRow.insertCell(0);
    let cellMessage = newRow.insertCell(1);
    let cellLastUpdate = newRow.insertCell(2);

    //keep this?
    cellMessage.classList.add("tdbreak");

    if (newMsg == undefined) {
        cellMessage.innerHTML = "Aucun message";
    } else {
        cellID.innerHTML = newMsg.ID;
        cellMessage.innerHTML = newMsg.message.replace(/\n/g,"<br>");
    
        //let lastUpdate = Date.parse(lastUpdate);
        let offset = newMsg.lastUpdate.getTimezoneOffset();
        let lastUpdate = new Date(newMsg.lastUpdate.getTime() - (offset * 60 * 1000));
        cellLastUpdate.innerHTML = lastUpdate.toISOString().replace("T"," ").substring(0,16).replace(":", " h ");
    }
}

refreshContacts();
refreshMsgContacts();
refreshMsg();
viewSection('intro');