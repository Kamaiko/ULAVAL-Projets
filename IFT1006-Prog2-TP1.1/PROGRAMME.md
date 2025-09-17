# PROGRAMME.md - Analyse et stratégie de débogage

## 1. Cahier des charges

À la lumière d'une première observation du code, le programme est censé résoudre le problème suivant :

**Objectif :** Implémenter un jeu de morpion (tic-tac-toe) en ligne de commande pour deux joueurs.

**Fonctionnalités attendues :**
- Affichage d'une grille de jeu 3x3
- Alternance entre deux joueurs (ROND = O, CROIX = X)
- Saisie des coordonnées pour placer un pion
- Validation des coups (cases vides, indices valides)
- Détection des conditions de victoire (ligne, colonne, diagonale)
- Détection de match nul (grille pleine sans gagnant)
- Affichage du résultat final

**Architecture du code :**
- `programmePrincipal.cpp` : Boucle de jeu principale
- `fonctionsUtilitaires.h` : Déclarations des fonctions et constantes
- `fonctionsUtilitaires.cpp` : Implémentations des fonctions utilitaires

## 2. Stratégie de débogage

Pour corriger le programme, j'adopte la démarche systématique suivante :

### Phase 1 : Analyse statique et erreurs de compilation
1. **Compilation initiale** - Identifier toutes les erreurs de compilation
2. **Analyse du code** - Lecture méthodique de tous les fichiers source
3. **Correction des erreurs de syntaxe** - Résoudre les problèmes empêchant la compilation

### Phase 2 : Correction des erreurs de logique
1. **Lecture du code** - Comprendre ce que chaque fonction est censée faire
2. **Identification des problèmes** - Repérer les erreurs logiques évidentes
3. **Correction simple** - Ajuster le code qui semble incorrect

### Phase 3 : Validation
1. **Compilation finale** - S'assurer que le code compile sans erreur
2. **Exécution du programme** - Vérifier que le jeu démarre et fonctionne
3. **Test rapide** - Jouer une partie complète pour valider le fonctionnement

### Outils utilisés :
- **NetBeans IDE** - Pour compiler et voir les erreurs
- **GitHub Issues** - Pour documenter chaque bug trouvé
- **Commits Git** - Pour sauvegarder les corrections

Cette approche garantit une correction méthodique et documentée de tous les aspects du programme.