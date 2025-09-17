# Mini Serveur de Courriel

>(INF4533) Technologies Internet – Projet 2  

Ce projet implémente un mini-serveur permettant l’envoi et la réception de messages chiffrés entre utilisateurs via une interface web simple.  

---

## 🚀 Installation et lancement

1. **Cloner le projet** et installer les dépendances :  
   ```bash
   npm install



2. Démarrer le serveur :

```bash
  node index.js
```
Le serveur s’exécute par défaut sur le port 3000.
Ouvrez http://localhost:3000 dans un navigateur.
Vous devez maintenant fournir deux informations essentielles à l'expéditeur: **L'adresse IP de votre routeur** et votre **clé publique**
  
# 🖥️ Configuration du serveur (ordinateur A)

Le serveur (destinataire des messages) doit fournir deux informations essentielles à l’expéditeur :  
- L’adresse IP du routeur  
- La clé publique affichée dans l’interface  

---

### 1. Trouver l’adresse IP du routeur

**Windows :**  
- Ouvrir *Invite de commandes* (`cmd`) et entrer :  
  ```bash
  ipconfig

### MacOS / Linux

- Ouvrir *Terminal* et entrer :  
  ```bash
  ifconfig
  
Relever l’IPv4 Address sous Ethernet adapter ou Wireless LAN adapter.


### Obtenir la clé publique

Ouvrez http://localhost:3000
Dans l’onglet Accueil, la clé publique du serveur est affichée
Transmettez-la à l’expéditeur


# 📤 Connexion de l’expéditeur (ordinateur B)

L’expéditeur doit :

Entrer dans son navigateur l’adresse du serveur au format : 

```bash
  192.135.0.157:3000
```
Une fois la page web affichée, aller dans l’onglet **Carnet d’adresses** :

- Ajouter un nouveau contact  
- Associer la clé publique du destinataire  

Aller dans l’onglet **Messages** :

- Composer un message  
- L’envoyer au destinataire  

Le message sera affiché dans l’onglet **Messages** du destinataire (ordinateur A).

# 🛠️ Technologies utilisées

- **Serveur :** Node.js  
- **Framework :** Express  
- **Librairies :** node-forge, body-parser  


# 👥 Auteurs 

- [@Jean-Pierre Masri-Clermont](https://www.github.com/JPP44)
- [@Samuel Hein](https://www.github.com/SamHein8)
- [@Patrick Patenaude](https://www.github.com/Kamaiko)
- [@Lawrence Kater](https://www.github.com/lelwrence)
- [@Marco Klayton Djouwne](https://www.github.com/)
- [@Abdel-Gany Jr Odelele](https://www.github.com/2longAGO)


