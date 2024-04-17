``` mermaid

      classDiagram
      class Character {
            # weapons: Weapon
            + Name: string
            + Fight(): void

            
      }

      class Player {
            
      }

      class Enemy {

      }

      class Weapon {
            # power: float
      }

      class Sword {
            + BladeLength: float 
            + AttackWithSword(): void
      }

      class Gun {
            + Ammo: int
            + FireGun(): void
      }

      Characters "1" *--> "*" Weapon
      Player <|-- Character
      Enemy <|-- Character
      Sword <|-- Weapon
      Gun <|-- Weapon
```