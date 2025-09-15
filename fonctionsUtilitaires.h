/**
 * \file fonctionsUtilitaires.h
 * \brief  déclarations des fonctions utilitaires
 * \author THE
 * \version 0.1
 */

#ifndef FONCTIONSUTILITAIRES_H
#define FONCTIONSUTILITAIRES_H

#include <array>
const int NB_LIGNE
{
    3
};
const int NB_COLONNE
{
    2
};







void initialiseGrille(std::array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE > p_grille); 
void afficheGrille(std::array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille);
void metUnPionSurLaGrille(std::array<std::array<ValeurGrille, NB_COLONNE>, NB_LIGNE >& p_grille, ValeurGrille* p_joueur);

#endif /* FONCTIONSUTILITAIRES_H */

