Enumerations:

Enumerations are often referred to as genomes. They are a special data type with a specific subset of possible values. They can be created either inside or outside of a class. You put an enumeration inside a class when you want only that class to have access to it. Outside of the class, the enumeration is in the global scope.

The proper syntax of creating a genome is using the proper keyword "enum", followed by a name as with other variables and functions. However, you can use a capital letter at the beginning of the name for a genome, because you are declaring a type, not a variable. Then you list the various constants in the genome within curly brackets, separated by commas. Unlike other braces used in C#, you must put a semicolon afterwards because it is the end of a statement.

By default, every constant in an enumeration has a value - an integer starting at zero for the first entry and rising sequentially - but they can be overridden as the code needs them to be. You can use the entries of the enumeration as values and variables in other functions throughout your program, just as using entries within other constructors.
