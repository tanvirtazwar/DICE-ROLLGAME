# 🎲 Dice RollGame 🎲


## Project

This project implements a classic dice guessing game in *C#*.

## Features

- **Random Number Generation**

- **Interactive Feedback**

- **Win/Lose Tracking**

## Project Stack

- Programming Language: *C#*

- Development Environment (Recommended): **Visual Studio**

## How to Run the Project

1. Clone this repository.
   ```
   Bash

   https://github.com/tanvirtazwar/DICE-ROLLGAME.git
   ```

2. Open the solution file `.sln` in **Visual Studio**.

3. Ensure you have *C#* development tools installed in **Visual Studio**.

4. Click the `▶️Run` button (or press `F5`) to start the game.

## How to Play

1. **Roll the Dice:** The program secretly generates a random number between 1 and 6 (the "rolled" number).

2. **Guess the Number:** You have 3 attempts to guess the rolled number.

3. **Feedback:**
   - **Correct Guess:** Program prompts `You Won`.
   - **Wrong Guess:** The program prompts `Wrong Answer` and provides another attempt.
   - **Invalid Input:** If you enter something besides a number, the program prompts you to `Incorrect Input`.

4. **Win or Lose:** After 3 guesses
   - **Win:** You correctly guessed the rolled number.
   - **Lose:** You exhausted your attempts without guessing correctly.
