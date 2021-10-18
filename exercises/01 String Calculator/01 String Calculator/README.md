# String calculator #
Build an application that calculates the sum of a string containing separated numbers.

## Practical approach ##
Do this exercise in a pair, and repeat the following cycle:
- Person A takes the top most requirement from the list below and writes a failing unit test for it.
- Person B implements the code so that the unit test succeeds.
- If needed, person B can refactor the code after the test succeeds.
- Now person B takes the second requirement and writes a failing unit test for it.
- Person A implements the code so that all unit tests succeed.
- If needed, person A can refactor the code again.
- Repeat until all requirements are implemented.

## Requirements ##
- An empty string returns zero
- A single number returns the value
- Two numbers, comma delimited, returns the sum
- Two numbers, newline delimited, returns the sum
- Three numbers, delimited either way, returns the sum
- Negative numbers throw an exception
- Numbers greater than 1000 are ignored
- A single char delimiter can be defined at the beginning of the first line, e.g. "***//#***" for a '#' as the delimiter
- A multi char delimiter can be defined at the beginnen of the first line, e.g. "***//[###]***" for '###' as the delimiter
- Many single or multi-char delimiters can be defined at the beginning of the first line, e.g. "***//[###][$$]***" for '###' and '$$' as the delimiter

## Credits ##
Credits go to [Roy Osherove](http://osherove.com/tdd-kata-1/) for creating this exercise and [Peter Provost](http://www.peterprovost.org/blog/2012/05/02/kata-the-only-way-to-learn-tdd/) for rewriting the steps.