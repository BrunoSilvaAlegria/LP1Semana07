``` mermaid

      classDiagram
      class Character {

      }

      class Player {

      }

      class Enemy {

      }

      class Weapon {

      }

      class Sword {

      }

      class Gun {

      }

      Characters *--> Weapon
      Player <|-- Character
      Enemy <|-- Character
      Sword <|-- Weapon
      Gun <|-- Weapon
```