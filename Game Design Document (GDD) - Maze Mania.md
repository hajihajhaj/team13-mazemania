# Game Design Document (GDD) - Maze Mania

  

## 1. Game Overview 

**Game Title:**   

Maze Mania 

  

**Genre:**   

Cooperative, Puzzle, Time-based 

  

**Platform:**   

PC, Console  

  

**Target Audience:**   

Casual players enjoy cooperative games and working with friends to solve challenges. 

  

**Target age:**   

13+ 

  

--- 

  

## 2. Gameplay Overview 

The game is a split-screen co-operative maze game where two players must work together to navigate mazes, solve puzzles, and avoid traps. Each player can only see certain parts of the other player’s maze and they need to communicate to guide each other through. 

  

**Core Gameplay Loop:**   

- **Navigate**: Each player moves through their own maze discovering traps and puzzles that the other player needs help with. 

- **Communicate**: Players share clues and directions to avoid traps or solve puzzles. 

- **Solve Puzzles**: Players work together to overcome obstacles and reach the finish line before the time runs out. 

- **Progress**: The game ends successfully when both players reach the finish line. If the timer runs out, they lose and must restart. 

  

--- 

  

## 3. Game Objectives 

**Primary Objective:**   

Players must reach the end of the maze together, using communication and teamwork to overcome traps and puzzles within a time limit. 

  

**Objective Question:**   

"How effectively can players handle teamwork and communication under time pressure?" 

  

--- 

  

## 4. Player Objectives (Prototype Focus) 

The prototype will aim to answer the following question:   

  

"How does restricting player visibility to only certain parts of the maze impact teamwork and communication?" 

  

--- 

  

## 5. Puzzle and Trap System 

### Color Code Doors 

- **Clue Location**: In Player 1’s maze, place a green light as the clue. 

- **Puzzle Location**: In Player 2’s maze, add three doors (green, orange, purple). 

- **Mechanic**: Player 1 tells Player 2 the correct color (green). If Player 2 touches the wrong door, they die and return to the maze start. 

  

### Timed Trap Door 

- **Clue Location**: Not needed (direct action puzzle). 

- **Puzzle Location**: In Player 2’s maze, place a button. 

- **Mechanic**: Player 2 presses the button to open a door in Player 1’s maze temporarily. Player 1 must quickly move through before it closes. If they don’t make it, Player 2 must press the button again. 

  

### Laser Grid Puzzle 

- **Clue Location**: In Player 1’s maze, display the sequence Left-Right-Right as a clue. 

- **Puzzle Location**: In Player 2’s maze, set up a laser grid with a control panel. 

- **Mechanic**: Player 2 enters the correct sequence to deactivate the lasers. Entering the wrong sequence keeps the laser active, and Player 2 must try again. 

  

--- 

  

## 6. Communication and Navigation Mechanics 

**Restricted Visibility**: Each player can only see certain traps and paths in the other player’s maze, requiring them to communicate to navigate effectively. 

 

**Timer**:   

The game has a time limit to complete the maze, creating urgency and pressure for quick communication. 

  

--- 

  

## 7. Player Experience Goals 

We want players to feel the rush of navigating the maze under a time limit and the excitement of working with a friend to succeed. The game is designed to be fast-paced and fun, creating a strong sense of teamwork and shared victory. 

   

--- 

  

## 8. Conclusion 

The split-screen cooperative maze game is designed to test and enhance teamwork, communication, and memory. The primary mechanic to be examined in the prototype is the restricted visibility and how it impacts player engagement and communication under time pressure. 

  

 