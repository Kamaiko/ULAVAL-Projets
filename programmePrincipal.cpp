/**
 * \file programmePrincipal.cpp
 * \brief  ... question 1 : cahier des charges
 *
 *
 *
 *
 *
 * \author THE
 * \version 0.1
 */

#include <iostream>
#include "fonctionsUtilitaires.h"

using namespace std;


int main ()
{
  array<array<ValeurGrille, NB_COLONNE>, NB_LIGNE > grilleDeJeu; /* grille du morpion valeurs possibles VIDE, ROND ou CROIX */
  /* indique quel sera le prochain joueur a mettre un pion dans la grille ie soit ROND soit CROIX */
  ValeurGrille joueur = ROND;
  initialiseGrille (grilleDeJeu);
  do
    {
      cout << endl << "joueur " << joueur << " joue" << endl;
      metUnPionSurLaGrille (grilleDeJeu, joueur); 
      afficheGrille (grilleDeJeu); 
    }
  while (!testeFinJeu (grilleDeJeu));
  return 0;
}
