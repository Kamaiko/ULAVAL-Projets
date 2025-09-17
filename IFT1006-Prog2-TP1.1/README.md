[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/LJ8uon1j)
# Patrick Patenaude - patrick.patenaude.1@ulaval.ca - 537306327


# TP1 - Démarche d'investigation

## Étapes préliminaires

***⚠️ Rappel des 3 étapes préliminaires que vous avez du faire pour le laboratoire de préparation au TPs se trouvant dans Contenu et activités/semaine 3. Ces étapes ayant été faites pour le laboratoire, vous pouvez passer à la section Démarche d'investigation avec issues.***

1. Directement dans la machine virtuelle, ouvrir un terminal.

2. Dans le terminal, effectuer les deux commandes suivantes:
   
   ***Mettre le courriel et le nom d'utilisateur correspondant à votre compte GitHub.***
   
   - `git config --global user.email "email"`
   - `git config --global user.name "username"`

3. Générer une clé SSH en suivant les deux tutoriels suivants:
   
   1. https://docs.github.com/fr/authentication/connecting-to-github-with-ssh/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent?platform=linux
   2. https://docs.github.com/fr/authentication/connecting-to-github-with-ssh/adding-a-new-ssh-key-to-your-github-account

## Démarche d'investigation avec issues

But: Investiguer afin de corriger un programme. Vous devez alors décrire et illustrer toute la démarche que vous aurez adoptée pour atteindre cet objectif, ceci en utilisant les "issues" de GitHub. Il s’agit d’être complet, mais concis. Attention, il s'agit ici de valider une démarche d'investigation. Les justifications par la preuve des outils utilisés pour localiser puis corriger les erreurs sont plus importantes que les corrections du code en tant que tel. Vous devez documenter les bugs à l'aide d'"issues" et en faire la correction. 

1. Après avoir accepté l'assignment, cloner le dépôt dans la machine virtuelle avec la commande:
   
   - `git clone <url>` Assurez-vous de choisir l'URL SSH.

2. Ouvrir le projet dans NetBeans avec File>Open Project...:

3. Examiner le programme et écrire dans le fichier PROGRAMME.md : 
   
   1. Cahier des charges : Quel est, à la lueur d’une première observation du code, le problème qu’est censé résoudre le programme?
   2. Stratégie : comment comptez-vous vous y prendre pour corriger le programme? (Il s'agit de formaliser votre démarche en décrivant toutes les différentes étapes (du début à la fin, même celles faites intuitivement) que vous suivez).

4. Appliquez votre stratégie pour corriger le programme.

5. Documenter dans des issues tous les problèmes. On peut retrouver tous les types d'erreurs (erreur de syntaxe, mise en garde à corriger, mauvaise pratique, erreur d’édition de lien, erreur de logique (erreur à l’exécution) ). Les issues doivent être bien documentées pour chaque erreur identifiée. Vous devez indiquer le type de l'erreur et justifier par des preuves comment vous l’avez localisée (copies d’écran montrant les moyens que vous avez utilisé pour le faire, commentaires d’explication des messages d’erreur détaillant votre analyse, etc.). Voir les exemples d'issues documentées fournies dans le dépôt solution du laboratoire de préparation au TP1 https://github.com/GIF-1003/Laboratoire-Preparation-TP1-Solution. On demande une issue par bug trouvé.
   
    ***Vous devez suivre la structure Localisation-Problème-Solution comme démontrée dans le laboratoire.***

6. Corriger chacun des bugs trouvés (étape itérative liée à une itération de l’étape 5)  en illustrant l'efficacité de ces corrections (copie d’écran démontrant que l’erreur
   est effectivement corrigée) et effectuer un commit et un push de la solution. Il est recommandé de faire des commits et pushs régulièrement afin de sauvegarder son travail.
   Remarque : seules les corrections des erreurs de mauvaise pratique ne nécessitent pas de preuve d'efficacité, mais l'explication est attendue.

7. Ne pas oublier de faire un dernier commit et push du code final corrigé **toujours sur la branche main**.

8. Finalement, ajouter 2 captures d'écrans en commentaire dans la demande de révision (Pull Request) "Feedback" qui montre le résultat de la compilation et de l'exécution du programme une fois les bugs corrigés.
   
   
  ![{CC5D2B8C-1EC5-4AC1-84CF-01740B574316}](https://github.com/user-attachments/assets/b40e212c-23c4-4e71-9f48-38c02115a99f)
