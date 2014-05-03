#This is my first attempt at using Unity to create a game

#Controls:

A           - move left
D           - move right
Space or W  - jump


<h2>Features:</h2>
<ul>
<li>Camera follows ball</li>
<li>Added directional light and shadows</li>
<li>Level resets when ball falls</li>
<li>Coins have sound and particle affects when picked up</li>
<li>Score is increased as play picks up coins</li>
<li>Sound of ball changes pitch and audio on each hit</li>
<li>Pink blocks are bouncy</li>
<li>Pink blocks are animated when bounced on</li>
</ul>

<h2>Notes:</h2>
* Textures from cgtextures.com
* Sounds from freesound.org
- Debug.Log(String) is a console printer for debugging
- Edit>Project Settings>Quality to change quality levels for 
whatever platform it's running on.
- Use "Is Trigger" in Collider to make things go through it and
use it as a trigger for something instead.
- Add the animation panel from the Window menu
- Loop animations in the Inspector
- for animation, set simulation space to World to make it NOT follow the source as the source moves.
- Velocity over Lifetime in particle system is great for simulating wind
- Use Transorm object whenever you are going to spawn something
- User StartCoroutine(method) to call other methods
- Objects can only have one Audio source so instead of having multiple sources, you just change out the audioclip and then play it. Set it up as a public variable so you can assign it in unity.
- Pay attention to which object has the Audio listener on it so 3d sounds work better
