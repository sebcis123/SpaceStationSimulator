# Space Station Simulator
A turn-based console simulation game written in C# where the player manages a space station and its crew to survive 10 turns. The game uses object-oriented principles, random events, and resource management mechanics.
## Features
- Assign crew members to station modules (Life Support, Power, Research, Hydroponics)
- Survive unexpected random events like:
  - Fire event - One random module catches fire and becomes damaged
  - System failure event - Causes one module to instantly break
  - Meteor shower event - Two random modules are damaged at once
  - Contamination event - Food is contaminated → lose 3 Food
  - Power outage event - Blocks energy generation this turn (even if PowerModule is assigned)
  - Strike event - Morale is low → crew refuses to work this turn
  - No event - Nothing happens this turn

  Events are created using a Factory pattern (RandomEventFactory)
- Each module can break down and be repaired by crew
- Manage 4 critical resources:
  - Oxygen
  - Energy
  - Food
  - Morale

  All resources decrease by 1 every turn.
- Lose if any resource reaches 0. Win if you survive 10 turns!
## Technologies
- Language: **C#**
- Type: **Console application**
- Paradigm: **Object-Oriented Programming**
- Concepts used:
  - Inheritance
  - Interfaces & abstraction
  - Polymorphism
  - SOLID principles
  - Factory pattern (event generator)
  - Composition (crew assigned to modules)
## UML Diagram
![download](https://github.com/user-attachments/assets/e6237407-c19d-4af5-808f-6c9c516b354e)
