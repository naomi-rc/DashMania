# Cool things I learned from each tutorial

## Basics
- Shift+Space to maximize game view window

## Programming
- Use FixedUpdate() method instead of Update() method for physics calculations

## Movement
- Restrict object tumbling either by adding axes constraints on the rigid body component or by creating and adding a physics material with static and dynamic friction set to 0

## Camera follow
- Have camera follow the player either by parenting the camera under the player object or by updating the camera transform according to the player's transform

## Collisions
- Detect collisions with method OnCollisionEnter(Collision collisionInfo){...} and collisionInfo.collider.tag

## Basic level design / Gameplay
- Easily add fog to a game via the lighting settings

## Score and UI
- C#'s ToString() method can specify precision by just passing it as a string i.e. ToString("0")
