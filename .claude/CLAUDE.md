# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a C++ tic-tac-toe (morpion) game project for a university programming course (IFT-1006 TP1). The project is designed as a debugging exercise where students must identify and fix intentionally introduced bugs using GitHub issues to document their debugging process.

## Build and Development Commands

The project uses NetBeans IDE with a Makefile build system:

```bash
# Build the project
make build

# Clean build artifacts
make clean

# Clean all build artifacts
make clobber

# Build all configurations
make all

# Run tests (if available)
make test

# Get help with make targets
make help
```

NetBeans configurations:
- Debug configuration: includes debugging symbols and warnings level 2
- Release configuration: optimized build

## Code Architecture

### File Structure
- `programmePrincipal.cpp`: Main program entry point, contains game loop
- `fonctionsUtilitaires.h`: Header file with function declarations and constants
- `fonctionsUtilitaires.cpp`: Implementation of utility functions for the tic-tac-toe game

### Key Components

**Game Data Structures:**
- `ValeurGrille` enum: Represents cell states (VIDE, ROND, CROIX)
- 2D array: `array<array<ValeurGrille, NB_COLONNE>, NB_LIGNE>` for the game grid
- Constants: `NB_LIGNE` and `NB_COLONNE` define grid dimensions

**Core Functions:**
- `initialiseGrille()`: Initializes the game grid to empty state
- `afficheGrille()`: Displays the current game state
- `metUnPionSurLaGrille()`: Handles player input and piece placement
- `testeFinJeu()`: Checks for win conditions or draw

### Known Issues

This is a debugging exercise project that contains intentional bugs. When working on this codebase, expect to find:
- Compilation errors (syntax, type mismatches, undefined symbols)
- Logic errors (incorrect array indexing, wrong loop conditions)
- Design inconsistencies (parameter passing issues, missing includes)
- Runtime errors that may not be immediately apparent

The debugging process should be documented using GitHub issues following the "Localisation-Problème-Solution" structure as outlined in the course requirements.

## Development Workflow

1. Open project in NetBeans (File > Open Project...)
2. Build using make commands or NetBeans build tools
3. Document any bugs found as GitHub issues
4. Fix bugs iteratively with commits
5. Verify fixes with compilation and execution tests
6. Final verification should show successful compilation and execution

## Project Context

This is part of a university assignment (TP1) for debugging methodology learning. The main goal is to practice systematic debugging approaches rather than just fixing the code.