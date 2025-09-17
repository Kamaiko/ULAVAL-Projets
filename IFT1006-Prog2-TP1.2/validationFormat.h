

#ifndef VALIDATIONFORMAT_H
#define VALIDATIONFORMAT_H

#include <iostream>

bool validerCodeProduit(const std::string& p_code, const std::string& p_nom, double p_prix);

bool validerFormatFichier(std::istream& p_is);

#endif /* VALIDATIONFORMAT_H */

