This is my first attempt at using Unity to create a game

Controls:
A           - move left
D           - move right
Space or W  - jump

Features:
Camera follows ball
Added directional light and shadows
Level resets when ball falls



notes:
-Textures from cgtextures.com
-Debug.Log(String) is a console printer for debugging
-Edit>Project Settings>Quality to change quality levels for 
whatever platform it's running on.
-Use "Is Trigger" in Collider to make things go through it and
use it as a trigger for something instead.
-Add the animation panel from the Window menu
-Loop animations in the Inspector
-for animation, set simulation space to World to make it NOT follow the source as the source moves.
-Velocity over Lifetime in particle system is great for simulating wind
-Use Transorm object whenever you are going to spawn something
