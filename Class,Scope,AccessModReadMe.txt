<Class:>

Classes house the variables and functions of a program.

They are used to group several things that work together in the program - an object oriented tool for Object Oriented Programming, as in C#.

The intent is to split the script into multiple scripts, so that, unlike JavaScript, you don't have one massive block of complicated text and code. Each little script is meant to take on a single goal, and only working on that specific task. One class is dedicated to one task. Another task is held in another class.

Classes can have subclasses to organize variables even further.

To use the class, you must create an instance (object) defined by the name of the class, much like calling a function or variable. Then you create a constructor with the name of the class. This constructor is a function without a return that sets parameters for the variables within.

A class can have several constructors, but only one is called when the class is initialized.

<Scope and Access Modifiers:>

The scope of a variable is the area in the code where the variable can be used - the area of code it can be used in makes the variable "local". Generally, the scope is defined by code blocks (bracket braces).

Variables defined in a class have keywords that regulate access to them, unlike those declared in a function. These keywords, or access modifiers, are placed before a data type when you are declaring a variable.

Access modifiers define where a variable or function can be seen throughout the code.

"Public" modifiers allow other functions to see and have access to the given variable outside the class. Conversely, if the modifer is "Private" other functions cannot see or access it. 

"Private" is the default of any variable that has not been otherwise specified. It is good practice to keep variables private unless they need to be public for a specific reason. This keeps things solid and ensures other scripts don't accidentally access them unless you intend for them to do so.



