# Implementation plan: Hangman game in C# (console)

## Context
The developer is a C# beginner who wants to learn the fundamentals by building a console hangman game. No hangman drawing, French words without accents or special characters, a fixed list of words, and the simplest possible code.

## Step 0: save this plan
- This file (`PLAN.md`) lives in the project folder and is written **before any code**.
- Tick the steps below as we go.

## Step 1: create the project (no game code)
- [x] Check the SDK: `dotnet --version`.
- [x] Run `dotnet new console` in `MonPendu` -> `MonPendu.csproj` + `Program.cs`.
- [x] Replace the generated `Hello, World!` with a title line only (an empty file does not compile: error CS5001, no entry point).
- [x] Verify: `dotnet build`, `dotnet run`.

## Step 2: explain how hangman works (in chat, no code)
Concepts: variables, arrays, `Random`, `while`, `if`, `string`, `char`, `foreach`.

## Implementation steps (one at a time, validated each time)
1. [x] **Secret word**: array of `string` + `Random`; print the word (temporary test).
2. [ ] **Masked word**: display `_ _ _ _` based on found letters (`foreach` loop).
3. [ ] **Input**: `Console.ReadLine()`, check a single letter a-z, lowercase.
4. [ ] **Already tried letters**: reject a letter already played.
5. [ ] **Letter check**: correct -> revealed; wrong -> lose one life.
6. [ ] **Game loop**: `while` until win or 0 lives left.
7. [ ] **End of game**: win/lose message + reveal the word.
8. [ ] **Replay** (optional, last).

## Working rules
- All conversations in French; this file is in English.
- Code commented for a beginner (explain the why).
- Small steps; build and run after each step; no unrequested refactoring.

## Verification
`dotnet build` with no errors; `dotnet run` after each step, with the result explained.

