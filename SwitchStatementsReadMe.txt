Switch Statements:

A switch statement is an alternative to if/else statements when making decisions in code, particularly if there is a series of decisions to be made, rather than a few true or false conditions. A switch is a more streamlined conditional when you want to compare one variable to a series of constants. Switches are commonly used when working with enumerations.

The syntax of a switch statement begins with the keyword "switch" followed by the variable it will be comparing inside parentheses. Within the usual braces of most coding commands, you must define a series of cases - these are the constants against which you will be comparing the variable. Each case is like it's own "if" statement. If the variable matches one case, X will run, but if it matches another, Y will run. After each case, you must separate each of them with a jump, most commonly "break;". 

In the final case, you want to catch everything that doesn't have a case of its own. Thus, your final case is "default", which will only be used if your variable doesn't match any of the cases you have defined. Essentially, it is the "else" in an if/else statement. It doesn't need a value and it's usually used for inputs that do not match the parameters of the command.
