/*
 * Fichier: validationFormat.cpp
 * Auteur: Patrick Patenaude (patrick.patenaude.1@ulaval.ca)
 * Date: Septembre 2025
 * Description: Implementation des fonctions de validation pour codes produits et catalogues
 */

 #include "validationFormat.h"
 #include <string>
 #include <sstream>
 #include <cmath>
 
 using namespace std;
 
 // ============================================================================
 // FONCTIONS UTILITAIRES
 // ============================================================================
 
 /**
  * Extrait les 4 premiers caracteres alphabetiques d'un nom
  * @param nom Le nom du produit
  * @return String de 4 caracteres en majuscules
  */
 string extraireCaracteresAlphabetiques(const string& nom)
 {
   string resultat = "";
 
   for (int i = 0; i < nom.size(); i++)
   {
     char lettre = nom[i];
 
     // Si c'est une lettre
     if ((lettre >= 'A' && lettre <= 'Z') || (lettre >= 'a' && lettre <= 'z'))
     {
       // Convertir en majuscule si necessaire
       if (lettre >= 'a' && lettre <= 'z')
       {
         lettre = lettre - 'a' + 'A';
       }
 
       resultat += lettre;
 
       // Arreter quand on a 4 lettres
       if (resultat.size() == 4)
       {
         break;
       }
     }
   }
 
   return resultat;
 }
 
 /**
  * Calcule la cle de controle selon l'algorithme specifie
  * @param caracteres Les 4 caracteres extraits du nom
  * @param prix Le prix du produit
  * @return La cle de controle (somme modulo 100)
  */
 int calculerCleControle(const string& caracteres, double prix)
 {
   int somme = 0;
 
   // Ajouter les valeurs des lettres (A=1, B=2, etc.)
   for (int i = 0; i < 4; i++)
   {
     somme += (caracteres[i] - 'A' + 1);
   }
 
   // Ajouter les deux chiffres des cents du prix
   int cents = (int)round(prix * 100) % 100;
   somme += (cents / 10) + (cents % 10);
 
   return somme % 100;
 }
 
 /**
  * Verifie si une taille de vetement est valide
  * @param taille La taille a valider
  * @return true si la taille est valide, false sinon
  */
 bool estTailleVetementValide(const string& taille)
 {
   return (taille == "XS" || taille == "S" || taille == "M" ||
           taille == "L" || taille == "XL" || taille == "XXL");
 }
 
 /**
  * Valide l'entete d'un fichier catalogue (nom + date)
  * @param flux Le flux d'entree
  * @param premiereLigne Reference pour stocker le nom du catalogue
  * @return true si l'entete est valide, false sinon
  */
 bool validerEnteteFichier(istream& flux, string& premiereLigne)
 {
   bool estValide = false;
   string ligne;
 
   // Lire le nom du catalogue
   if (getline(flux, ligne) && !ligne.empty())
   {
     premiereLigne = ligne;
 
     // Lire et valider la date
     if (getline(flux, ligne))
     {
       stringstream ss(ligne);
       int jour, mois, annee;
       string reste;
 
       // Valider qu'on lit exactement 3 entiers et rien d'autre
       if ((ss >> jour >> mois >> annee) && !(ss >> reste))
       {
         // Valider les plages de dates
         if (jour > 0 && jour <= 31 &&
             mois > 0 && mois <= 12 &&
             annee > 0)
         {
           estValide = true;
         }
       }
     }
   }
 
   return estValide;
 }
 
 /**
  * Valide une ligne de produit du catalogue
  * @param ligne La ligne a valider
  * @return true si la ligne est valide, false sinon
  */
 bool validerLigneProduit(const string& ligne)
 {
   bool estValide = false;
   stringstream produitStream(ligne);
   string type, nom, prixStr, codeProduit, attribut1, attribut2;
 
   // Parser les 6 champs
   if (getline(produitStream, type, ',') &&
       getline(produitStream, nom, ',') &&
       getline(produitStream, prixStr, ',') &&
       getline(produitStream, codeProduit, ',') &&
       getline(produitStream, attribut1, ',') &&
       getline(produitStream, attribut2))
   {
     // Verifier le type de produit
     if (type == "Electronique" || type == "Vetement")
     {
       // Convertir et valider le prix
       double prix = 0.0;
       stringstream prixSs(prixStr);
       string reste;
 
       // Valider qu'on lit exactement un nombre et rien d'autre
       if ((prixSs >> prix) && !(prixSs >> reste) && prix >= 0)
       {
         // Valider le code produit
         if (validerCodeProduit(codeProduit, nom, prix))
         {
           // Validation specifique pour vetements
           if (type == "Vetement")
           {
             if (estTailleVetementValide(attribut1))
             {
               estValide = true;
             }
           }
           else
           {
             estValide = true;
           }
         }
       }
     }
   }
 
   return estValide;
 }
 
 // ============================================================================
 // FONCTIONS PRINCIPALES
 // ============================================================================
 
 /**
  * Valide un code produit selon le format PRD-XXXX-YY
  * @param p_code Le code a valider
  * @param p_nom Le nom du produit
  * @param p_prix Le prix du produit
  * @return true si le code est valide, false sinon
  */
 bool validerCodeProduit(const string& p_code, const string& p_nom, double p_prix)
 {
   bool estValide = false;
 
   // Verifier la longueur et le format exact PRD-XXXX-YY
   if (p_code.size() == 11 &&
       p_code.substr(0, 4) == "PRD-" &&
       p_code[8] == '-')
   {
     // Extraire les caracteres du nom
     string caracteresNom = extraireCaracteresAlphabetiques(p_nom);
     if (caracteresNom.size() == 4)
     {
       // Verifier que les caracteres du code correspondent
       string caracteresDuCode = p_code.substr(4, 4);
       if (caracteresDuCode == caracteresNom)
       {
         // Verifier la cle de controle
         int cleAttendue = calculerCleControle(caracteresNom, p_prix);
         string cleString = p_code.substr(9, 2);
 
         // Valider le format de la cle (2 chiffres)
         if (cleString.size() == 2 &&
             cleString[0] >= '0' && cleString[0] <= '9' &&
             cleString[1] >= '0' && cleString[1] <= '9')
         {
           int cleFournie = (cleString[0] - '0') * 10 + (cleString[1] - '0');
           if (cleFournie == cleAttendue)
           {
             estValide = true;
           }
         }
       }
     }
   }
 
   return estValide;
 }
 
 /**
  * Valide le format complet d'un fichier catalogue
  * @param p_is Le flux d'entree du fichier
  * @return true si le format est valide, false sinon
  */
 bool validerFormatFichier(istream& p_is)
 {
   bool estValide = false;
   string nomCatalogue;
 
   // Valider l'entete (nom + date)
   if (validerEnteteFichier(p_is, nomCatalogue))
   {
     estValide = true;
 
     // Valider chaque ligne de produit
     string ligne;
     while (getline(p_is, ligne) && estValide)
     {
       // Verifier qu'il n'y a pas de ligne vide
       if (ligne.empty())
       {
         estValide = false;
       }
       else
       {
         // Valider la ligne de produit
         if (!validerLigneProduit(ligne))
         {
           estValide = false;
         }
       }
     }
   }
 
   return estValide;
 }
 