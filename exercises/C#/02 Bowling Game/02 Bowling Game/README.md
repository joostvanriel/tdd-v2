# Bowling Game #
Build an application that calculates a bowling game score. A bowling game consists of 10 frames. In each frame the plyaer has two opportunities to knock down 10 pins. The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.

A spare is when the player knocks down all 10 pins in two tries.  The bonus for
that frame is the number of pins knocked down by the next roll.  So in frame 3
above, the score is 10 (the total number knocked down) plus a bonus of 5 (the
number of pins knocked down on the next roll.)

A strike is when the player knocks down all 10 pins on his first try.  The bonus
for that frame is the value of the next two balls rolled.

In the tenth frame a player who rolls a spare or strike is allowed to roll the extra
balls to complete the frame.  However no more than three balls can be rolled in
tenth frame.

## Practical approach ##
Do this exercise in a pair, and repeat the following cycle:
- Person A thinks about a single simple requirement and writes a failing unit test for it.
- Person B implements the code so that the unit test succeeds.
- If needed, person B can refactor the code after the test succeeds.
- Now person B thinks about a second requirement and writes a failing unit test for it.
- Person A implements the code so that all unit tests succeed.
- If needed, person A can refactor the code again.
- Repeat until all requirements are implemented.

## Requirements ##
Think about these yourself (hint: should be doable in about five test cases)

## Credits ##
Credits go to Uncle Bob for creating the Bowling Game kata.