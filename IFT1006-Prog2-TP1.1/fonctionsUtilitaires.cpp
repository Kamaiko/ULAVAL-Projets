/**
 * \file fonctionsUtilitaires.cpp
 * \brief  implémentation (définitions) des fonctions utilitaires
 * \author THE
 * \version 0.1
 */
#include <iostream>

#include "fonctionsUtilitaires.h"
using namespace std;

/**
 * 
 * 
 */
void initialiseGrille (std::array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille)
{
  for (int i = 0; i < NB_LIGNE; i++)
    {
      for (int j = 0; j < NB_COLONNE; j++)
        {
          p_grille[i][j] = VIDE;
        }
    }
}


/**
 * 
 * 
 */
void afficheGrille (std::array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille)
{
  for (int i = 0; i < NB_LIGNE; i++)
    {
      for (int j = 0; j < NB_COLONNE; j++)
        {
          switch (p_grille[i][j])
            {
              case VIDE:
                cout << "_ ";
                break;
              case ROND:
                cout << "O ";
                break;
              case CROIX:
                cout << "X ";
                break;
            }
        }
      cout << endl; /* fin de la ligne */
    }
}


/**
 * \brief Saisie les coordonnees du nouveau pion a mettre sur la grille
 *  Si les coordonnees sont en dehors de la grille ou si la case possede
 *   deja un pion, la saisie est refusee, un message d'erreur est affichee,
 *   et le joueur doit rejouer
 * @param p_grille grille du jeu
 * @param p_joueur joueur qui joue
 */
void metUnPionSurLaGrille (array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille, ValeurGrille &p_joueur)
{
  bool saisieCorrecte = false;
  cout << "Numeros de ligne et de colonne: ";
  int ligne;
  int colonne;
  do
    {
      cin >> ligne; 
      cin >> colonne;
      cout << endl;

      if ((ligne > 0) && (ligne <= NB_LIGNE) && (colonne > 0) && (colonne <= NB_COLONNE))
        {
          ligne--; /* enleve 1 pour etre compatible avec le tableau ayant des
		  indices de 0 a NB_LIGNE-1 */
          colonne--;
          if (p_grille[ligne][colonne] != VIDE)
            cout << "Cette case a deja ete remplie. Veuillez recommencer"  << endl;
          else
            {
              saisieCorrecte = true;
              p_grille[ligne][colonne] = p_joueur; //ajouter les colonnes
              if (p_joueur == ROND)
                p_joueur = CROIX;
              else
                p_joueur = ROND;
            }
        }
      else
        cout << "Indice de ligne ou de colonne incorrect. Veuillez recommencer" << endl;
    }
  while (!saisieCorrecte);
}


/**
 * \brief Teste si l'un des joueurs a gagne (ligne, colonne ou diagonale remplit
 *    de pions semblables). Dans ce cas affiche un message pour indiquer le
 *    joueur qui a gagne.
 *    S'il n'y a pas de gagnant, teste que la grille n'est pas pleine. Si elle
 *    est pleine, affiche un message indiquant qu'aucun des joueurs a gagne
 * @param p_grille la grille du jeu en cours
 * @return true si la grille est pleine ou si un joueur a gagne
 *             false sinon
 */
bool testeFinJeu (array<array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille)
{
  ValeurGrille joueurGagnant; /* pour connaitre quel est le gagnant ie soit CROIX soit ROND */
  bool gagne = false;
  bool finDuJeu = true; 

  /* Teste s'il y a un gagnant */
  /* L'algorithme utilise est le plus facile mais n'est pas le plus efficace
     car on n'utilise pas la position du dernier pion ajoute sur la grille. Cette information
     permettrait de reduire le temps de la recherche.
     De plus, cet algo suppose que la taille de la matrice est de 3 par 3
   */
  /* si la case 1,1 est VIDE, cela signifie que les diagonales, la ligne 1 et la colonne 1 ne sont
     pas gagnantes
   */
  if (p_grille[1][1] != VIDE)
    {
      if (/* colonne 1 */ ((p_grille[0][1] == p_grille[1][1]) && (p_grille[1][1] == p_grille[2][1])) ||
          /* ligne 1 */ ((p_grille[1][0] == p_grille[1][1]) && (p_grille[1][1] == p_grille[1][2])) ||
          /* diagonale */ ((p_grille[0][0] == p_grille[1][1]) && (p_grille[1][1] == p_grille[2][2])) ||
          /* autre diag */ ((p_grille[0][2] == p_grille[1][1]) && (p_grille[1][1] == p_grille[2][0])))
        {
          joueurGagnant = p_grille[1][1]; /* ie ROND ou CROIX */
          gagne = true;
        }
    }

  /* si la case 0,0 est vide, cela signifie que la ligne 0 et le colonne 0 ne sont pas gagnantes */
  if ((!gagne) && (p_grille[0][0] != VIDE))
    {
      if ( /* ligne 0 */ ((p_grille[0][0] == p_grille[0][1]) && (p_grille[0][1] == p_grille[0][2])) ||
          /* colonne 0*/ ((p_grille[0][0] == p_grille[1][0]) && (p_grille[1][0] == p_grille[2][0])))
        {
          joueurGagnant = p_grille[0][0];
          gagne = true;
        }
    }

  /* si la case 2,2 est vide, cela signifie que la ligne 2 et la colonne 2 ne sont gagnantes */
  if ((!gagne) && (p_grille[2][2] != VIDE))
    {
      if ( /* ligne 2 */ ((p_grille[2][0] == p_grille[2][1]) && (p_grille[2][1] == p_grille[2][2])) ||
          /* colonne 2 */ ((p_grille[0][2] == p_grille[1][2]) && (p_grille[1][2] == p_grille[2][2])))
        {
          joueurGagnant = p_grille[2][2];
          gagne = true;
        }
    }

  if (gagne)
    {
      cout << "Felicitations au joueur ayant les ";
      if (joueurGagnant == ROND)
        {
          cout << "ronds ";
        }
      else
        {
          cout << "croix ";
        }
      cout << "qui a gagne." << endl;
    }
  else
    {
      /* teste si la grille n'est pas pleine */
      for (int i = 0; i < NB_LIGNE; i++)
        {
          for (int j = 0; j < NB_COLONNE; j++)
            {
              if (p_grille[i][j] == VIDE) /* Au moins une case est vide donc le jeu n'est pas fini */
                finDuJeu = false;
            }
        }
    }
  if (finDuJeu && !gagne)
    {
      cout << "aucun gagnant!";
    }

  return finDuJeu || gagne;
}
