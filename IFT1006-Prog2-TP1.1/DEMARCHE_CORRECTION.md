# TP1 - Démarche de correction du programme Morpion

## 1. Cahier des charges

À la lumière d'une première observation du code, le programme est censé résoudre le problème suivant:

**Objectif principal:** Implémenter un jeu de morpion (tic-tac-toe) en ligne de commande pour deux joueurs.

**Fonctionnalités attendues:**
- Affichage d'une grille de jeu 3x3
- Alternance entre deux joueurs (ROND = O, CROIX = X)
- Saisie des coordonnées pour placer un pion
- Validation des coups (cases vides, indices valides)
- Détection des conditions de victoire (ligne, colonne, diagonale)
- Détection de match nul (grille pleine sans gagnant)
- Affichage du résultat final

**Architecture du code:**
- `programmePrincipal.cpp`: Boucle de jeu principale
- `fonctionsUtilitaires.h`: Déclarations des fonctions et constantes
- `fonctionsUtilitaires.cpp`: Implémentations des fonctions utilitaires

## 2. Stratégie de débogage

Pour corriger le programme, j'adopte la démarche systématique suivante:

### Phase 1: Analyse statique et erreurs de compilation
1. **Compilation initiale** - Identifier toutes les erreurs de compilation
2. **Analyse du code** - Lecture méthodique de tous les fichiers source
3. **Correction des erreurs de syntaxe** - Résoudre les problèmes empêchant la compilation

### Phase 2: Correction des erreurs de logique
1. **Analyse du flux d'exécution** - Vérifier la logique de la boucle principale
2. **Tests des fonctions individuelles** - Vérifier chaque fonction séparément
3. **Correction des algorithmes** - Ajuster la logique défaillante

### Phase 3: Validation et tests
1. **Compilation finale** - S'assurer que le code compile sans erreur
2. **Tests d'exécution** - Vérifier le comportement du programme
3. **Tests de cas limites** - Valider les scénarios de victoire et de match nul

### Outils utilisés:
- **Compilateur g++** - Pour identifier les erreurs de compilation
- **GitHub Issues** - Pour documenter chaque bug selon la structure Localisation-Problème-Solution
- **Commits Git** - Pour tracer chaque correction apportée

## 3. Documentation des corrections appliquées

### Résumé des bugs identifiés et corrigés:

**PHASE 1: Erreurs de compilation (bugs critiques)**

#### Bug #1: Type ValeurGrille non défini dans le header (Issue #2)
- **Localisation:** fonctionsUtilitaires.h:27-30 et fonctionsUtilitaires.cpp:12-15
- **Problème:** L'enum `ValeurGrille` était défini dans le .cpp mais utilisé dans le .h
- **Messages d'erreurs associés:**
```
fonctionsUtilitaires.h:27:45: error: 'ValeurGrille' was not declared in this scope
fonctionsUtilitaires.h:28:42: error: 'ValeurGrille' was not declared in this scope
fonctionsUtilitaires.h:29:49: error: 'ValeurGrille' was not declared in this scope
fonctionsUtilitaires.h:29:98: error: 'ValeurGrille' has not been declared
```
- **Solution:** Déplacé l'enum du .cpp vers le .h pour qu'il soit accessible partout
- **Résultat:** Résolution des erreurs "'ValeurGrille' was not declared in this scope"

#### Bug #2: Dimension incorrecte de la grille (Issue #3)
- **Localisation:** fonctionsUtilitaires.h:23
- **Problème:** `NB_COLONNE` était défini comme 2 au lieu de 3 pour un morpion 3x3
- **Messages d'erreurs associés:**
```
void initialiseGrille(std::array<std::array<ValeurGrille, 2>, 3>&)
```
*(Le "2" dans la signature de fonction indique NB_COLONNE = 2 au lieu de 3)*
- **Solution:** Changé la valeur de 2 à 3
- **Résultat:** Grille maintenant correcte 3x3

#### Bug #3: Passage par valeur au lieu de référence (Issue #4)
- **Localisation:** fonctionsUtilitaires.h:33
- **Problème:** `initialiseGrille` recevait la grille par valeur (copie inefficace)
- **Messages d'erreurs associés:** *(Erreur masquée par les erreurs de compilation critiques)*
- **Solution:** Ajouté & pour passage par référence
- **Résultat:** Modification directe de la grille originale

#### Bug #4: Fonction testeFinJeu non déclarée (Issue #5)
- **Localisation:** fonctionsUtilitaires.h (manquant)
- **Problème:** Fonction utilisée dans main mais non déclarée dans le header
- **Messages d'erreurs associés:** *(Erreur masquée par les erreurs de compilation critiques)*
- **Solution:** Ajouté la déclaration `bool testeFinJeu(...)`
- **Résultat:** Résolution de l'erreur "'testeFinJeu' was not declared in this scope"

#### Bug #5: Incohérence des types de paramètres (Issue #6)
- **Localisation:** fonctionsUtilitaires.h:35 vs fonctionsUtilitaires.cpp:65
- **Problème:** Header attendait un pointeur, implémentation et appel utilisaient des références
- **Messages d'erreurs associés:** *(Erreur masquée par les erreurs de compilation critiques)*
- **Solution:** Unifié en utilisant des références (&) partout
- **Résultat:** Cohérence entre déclaration, implémentation et utilisation

#### Bug #6: Variables déclarées deux fois (Issue #7)
- **Localisation:** fonctionsUtilitaires.cpp:18-19
- **Problème:** Variables `i` et `j` déclarées ligne 18 puis redéclarées dans la boucle
- **Messages d'erreurs associés:**
```
fonctionsUtilitaires.cpp:23:7: warning: unused variable 'i' [-Wunused-variable]
fonctionsUtilitaires.cpp:23:9: warning: unused variable 'j' [-Wunused-variable]
```
- **Solution:** Supprimé la première déclaration ligne 18
- **Résultat:** Code plus propre, pas de warning de compilation

**PHASE 2: Erreurs de syntaxe**

#### Bug #7: Opérateur logique incorrect (Issue #8)
- **Localisation:** fonctionsUtilitaires.cpp:184
- **Problème:** `finDuJeu&!gagne` au lieu de `finDuJeu && !gagne`
- **Messages d'erreurs associés:** *(Erreur masquée par les erreurs de compilation critiques)*
- **Solution:** Ajouté le deuxième & pour l'opérateur ET logique
- **Résultat:** Évaluation logique correcte de la condition

#### Bug #8: Return manquant (Issue #9)
- **Localisation:** fonctionsUtilitaires.cpp:190
- **Problème:** Fonction `bool testeFinJeu` sans instruction return
- **Messages d'erreurs associés:**
```
fonctionsUtilitaires.cpp:195:1: warning: no return statement in function returning non-void [-Wreturn-type]
  195 | }
      | ^
```
- **Solution:** Ajouté `return finDuJeu || gagne;`
- **Résultat:** Fonction retourne correctement true si jeu fini, false sinon

**PHASE 3: Erreurs de logique**

#### Bug #9: Condition de boucle inversée (Issue #10)
- **Localisation:** programmePrincipal.cpp:31
- **Problème:** `while (testeFinJeu)` continuait tant que le jeu était fini
- **Messages d'erreurs associés:** *(Erreur logique - pas de message de compilation)*
- **Solution:** Inversé avec `while (!testeFinJeu)` pour continuer tant que le jeu n'est pas fini
- **Résultat:** Boucle de jeu fonctionne correctement

#### Bug #10: Initialisation incorrecte (Issue #11)
- **Localisation:** fonctionsUtilitaires.cpp:114
- **Problème:** `finDuJeu` initialisé à false, ne devenait jamais true
- **Messages d'erreurs associés:** *(Erreur logique - pas de message de compilation)*
- **Solution:** Initialisé à true, mis à false si case vide trouvée
- **Résultat:** Détection correcte de grille pleine

#### Bug #11: Indices inversés dans l'affichage (Issue #12)
- **Localisation:** fonctionsUtilitaires.cpp:38
- **Problème:** `p_grille[j][i]` au lieu de `p_grille[i][j]`
- **Messages d'erreurs associés:** *(Erreur logique - pas de message de compilation)*
- **Solution:** Corrigé l'ordre des indices
- **Résultat:** Affichage correct de la grille

## 4. Résultats finaux

### État après corrections:
✅ **Compilation:** Le programme compile sans erreurs ni warnings
✅ **Exécution:** Le programme démarre et fonctionne correctement
✅ **Fonctionnalités:** Toutes les fonctionnalités du morpion sont opérationnelles

### Test de validation:
- Grille 3x3 s'affiche correctement
- Placement des pions fonctionne (O et X)
- Alternance entre joueurs opérationnelle
- Validation des saisies active
- Programme prêt pour utilisation complète

---

**Mission accomplie:** Tous les bugs intentionnels ont été identifiés et corrigés suivant une méthodologie systématique d'investigation et de débogage.