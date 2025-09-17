# Tp1-partie-2-A25

# Deuxième partie : fonctions

## Rappel du plan de cours: Utilisation interdite de l’intelligence artificielle (IA) générative

*Les personnes étudiantes ne sont pas autorisées à utiliser l'IA générative dans ce cours pour les épreuves évaluées, en l'occurrence pour les travaux pratiques. Conformément au Règlement disciplinaire à l’intention des étudiants et étudiantes de l’Université Laval, le fait d’obtenir une aide non autorisée pour réaliser une évaluation est considéré comme une infraction relative aux études. Dans le cadre de ce cours, l’utilisation de l’IA générative est considérée comme une aide non autorisée. Cette infraction pourrait mener à l’application des sanctions prévues au Règlement disciplinaire.*

## Travail à réaliser

Il s’agit de constituer une librairie de fonctions utilitaires qui pourront être réutilisées dans le futur projet de session (TP2 et 3 ).
Dans les fichiers validationFormat.h et validationFormat.cpp, vous devrez implanter les fonctions de validation dont les spécifications sont les suivantes.

```
bool validerCodeProduit(const std::string& p_code, const std::string& p_nom, 
double p_prix); 
```

Cette fonction valide le format d’un code produit.

Chaque produit possède un code unique généré à partir de ses attributs (nom, prix, type, etc.) via un algorithme de hachage simplifié. Ce code est ensuite validé par une clé de contrôle calculée à partir de la somme pondérée des caractères.

### **Structure du code produit**

- Format : `PRD-XXXX-YY`
  - `XXXX` : 4 caractères alphanumériques dérivés du nom et du prix
  - `YY` : clé de contrôle calculée
- Exemple : `PRD-A3F9-42`

---

### **Algorithme de génération et validation**

1. Tout code commence par PRD-
2. Extraire les 4 premiers caractères du nom
3. Ajouter les deux chiffres après la virgule du prix (cents)
4. Convertir chaque caractère en valeur numérique (A=1, B=2, ..., 0–9 = eux-mêmes)
5. Calculer la somme pondérée des valeurs
6. Clé = somme modulo 100

#### Exemple :

Nom : "Livre", Prix : 29.99

- Nom → "LIVR" → L=12, I=9, V=22, R=18

- Prix → 99 → 9, 9

- Somme = 12 + 9 + 22 + 18 + 9 + 9 = 79

- Clé = 79 modulo 100 = **79**

- Code : `PRD-LIVR-79`
  
  Vous ne devez pas utiliser regex.

```
bool validerFormatFichier(std::istream& p_is);
```

Cette fonction valide le format du fichier de données texte lu par l’intermédiaire d’un flux d’entrée passé en paramètre.

Le fichier, qui ne doit contenir aucune ligne vide. 

La première ligne contient un nom de catalogue.

La deuxième ligne contient la date de sa dernière mise à jour sous la forme de 3 entiers strictement positifs : `jj mm aaaa (date de mise à jour)`

Ensuite, chaque ligne contient **éventuellement** des informations sur des produits avec les champs suivants, séparés par des virgules : 

        `type,nom,prix,codeProduit,attribut1,attribut2`

avec des attributs selon le type de produit:

- **Electronique** : `garantieMois`,`estReconditionne` (0 ou 1)
- **Vetement** : `taille`(XS, S, M, L, XL, XXL),`couleur`

(on pourrait avoir d'autres types, mais on se limera ici à seulement ceux-ci)

Exemple « générique » :

```
nom du catalogue
jj mm aaaa (date de mise à jour)
type de produit (si Electronique),garantieMois,estReconditionne
type de produit (si Vetement),nom,prix,codeProduit,taille,couleur
…
```

Il est possible d’avoir plusieurs produits de chaque type dans un ordre arbitraire.

Il est recommandé de constituer vos propres fichiers de données pour faire vos tests. Attention au format des fichiers texte, les fins de lignes ne sont pas codées de la même façon sous Windows et sous Linux. Il faut donc s’assurer que les fichiers de données texte sont bien au format de Linux.

## Important.

Pensez à développer un programme de test vous permettant de vérifier la conformité au cahier des charges de vos fonctions. Ce programme n’est pas à remettre. 

### Erreurs de compilation

Si un travail comporte ne serait-ce qu'une erreur de compilation, il sera fortement pénalisé, et peut même se voir attribuer la note zéro systématiquement.

### Erreurs à l'exécution

Testez intensivement vos programmes. Rappelez-vous qu'un programme qui ne plante pas n'est pas nécessairement sans bogue, mais qu'un programme qui plante même une seule fois comporte nécessairement un bogue. D'ailleurs, si un programme ne plante nulle part sauf sur l'ordinateur de votre ami, c'est qu'il comporte un bogue. Il risque donc de planter un jour ou l'autre sur votre ordinateur et, encore pire, sur celui des correcteurs.
Si vous ne testez pas suffisamment votre travail, il risque de provoquer des erreurs à l'exécution lors de la correction. La moindre erreur d'exécution rend la correction extrêmement difficile et vous en serez donc fortement pénalisés.

## Auto-correcteur

***Attention:*** Vous devez avoir les mêmes noms de fichier mentionnés dans l’énoncé, soit **validationFormat.h** et **validationFormat.cpp** ainsi que les mêmes signatures de fonctions :

```
bool validerCodeProduit(const std::string& p_code, const std::string& p_nom, double p_prix); 
bool validerFormatFichier (std::istream& p_is);
```

pour que les tests fonctionnent.

#### ⚠️ Dans Netbeans, lorsque vous compilez et exécutez le code en cliquant sur la flèche verte, vous obtenez le résultat des 20 tests automatiquement.

Lorsque vos fonctions sont terminées et prêtes à être soumises, vous pouvez exécuter les tests d'auto-correction directement sur GitHub en suivant ces étapes :

1. Accédez à votre dépôt sur GitHub et cliquez sur l'onglet **Actions** :

2. Sélectionnez l'onglet **Auto Evaluateur** :

3. Cliquez sur le workflow **Feedback** :

4. Finalement, cliquez sur **Re-run jobs** :

5. Une fois les tests exécutés, vous verrez un crochet vert indiquant que tous les tests ont réussi.

**Remarque : Les correcteurs utiliseront également ces tests d'auto-correction présents sur GitHub.**

#### Quelques pistes

- Une fonction ne devrait pas avoir plus d’un point de sortie (return) idéalement à la fin, en l’occurrence pour une fonction de validation qui retourne un booléen, il est préférable d’utiliser une variable locale bool qui sera affectée par l’algorithme et retournée à la fin de la fonction (un point de sortie).

- Pensez à utiliser les méthodes offertes par la classe string (size, compare, …)

- Pensez à aller visiter la documentation en ligne pour connaitre précisément les types des paramètres et les usages (et vous inspirer des exemples de code souvent proposés). Une bonne référence : https://www.cplusplus.com/reference/

- Structure classique pour un algorithme de validation à multiples conditions :
  
  ```
  valide = faux
  Si condition vraie
   Si condition vraie
      Si condition vraie alors valide devient vrai
  Retourner valide
  ```

- Ainsi il faut que toutes les conditions soient vraies pour que l’on retourne vrai. Si une condition est fausse, on ne teste pas les conditions suivantes (qui serait inutile) on retourne immédiatement faux. Avec cette structure simple, il est plus facile de tester. On peut aussi ajouter des conditions très facilement. Ainsi, on peut commencer avec une condition, on valide par un test, on en ajoute une autre, on valide l’ensemble complété, etc.
