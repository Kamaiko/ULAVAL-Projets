# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a C++ academic project (TP1 Part 2) for IFT-1006 Programming course at Université Laval. The project implements a validation library for product catalogs with two main functions:

1. `validerCodeProduit()` - Validates product codes using a specific format (PRD-XXXX-YY) with checksum validation
2. `validerFormatFichier()` - Validates catalog file format with specific structure requirements

## Build Commands

### Compilation
```bash
# Compile the main validation module
g++ -std=c++14 -O0 -g3 -Wall -c -fmessage-length=0 -MMD -MP -MF"validationFormat.d" -MT"validationFormat.o" -o "validationFormat.o" "validationFormat.cpp"

# Link with test framework (Google Test)
g++ -o "test" ./validationFormat.o ./validationFormatTesteur.o -lgtest -lgtest_main -lpthread
```

### Running Tests
```bash
# Execute the test suite
./test
```

### Using Makefile
```bash
# Build the project
make build

# Run tests
make test

# Clean build artifacts
make clean

# Remove all built files
make clobber
```

## Architecture

### Core Files
- `validationFormat.h` - Header file with function declarations
- `validationFormat.cpp` - Implementation of validation functions
- `validationFormatTesteur.o` - Pre-compiled test object file

### Test Data Files
Various catalog files for testing different scenarios:
- `catalogue_produits_valide.txt` - Valid catalog example
- `catalogue_*_invalide.txt` - Invalid catalog test cases
- `catalogue_*_valide.txt` - Valid catalog variations

### Product Code Validation Algorithm
Product codes follow format `PRD-XXXX-YY` where:
- XXXX: 4 alphanumeric characters from product name
- YY: Checksum calculated from name characters + price cents (mod 100)

### File Format Structure
1. Catalog name (first line)
2. Date in format "jj mm aaaa" (second line)
3. Product entries: `type,nom,prix,codeProduit,attribut1,attribut2`
   - Electronique: `garantieMois,estReconditionne`
   - Vetement: `taille,couleur`

## Development Notes

- Project uses NetBeans IDE configuration (nbproject directory)
- GitHub Classroom auto-grading is configured
- Must maintain exact function signatures for auto-grader compatibility
- No regex usage allowed per assignment requirements
- Files must use Linux line endings format

## Important Academic Guidelines

- This is an academic project where AI assistance is prohibited
- Commits should be clean and professional without emojis or automated indicators
- Use traditional academic code style
- Keep commit messages simple and descriptive
- Avoid any patterns that suggest automated assistance