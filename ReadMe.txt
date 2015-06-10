KnightSequences:
----------------
A friend of mine had an interview with Getco a couple of months ago, he told me about this problem then. Not able to let it go, I started developing a solution using a unit test driven approach.

Once I finished the problem, I started thinking about optimization, I wanted to see how long of a sequence I'd be able to process in a minute.
I realized that if you cashe a combination of;
    1. The key position
    2. The number of moves left
    3. The number of vowels left
and, once processed, store it with the number of valid moves from there on you will hit this combination quite often later on in the program.

This optimization made it possible to get through a sequence of 65 in less than a minute, before optimizing, I was only able to do 12, huge difference!

The code should be self documenting, especially the unit tests.