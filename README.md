# Dependency-Inversion-Principle
A repo that contains code to illustrate the application of the Dependency Inversion Principle (DIP).

This principle states that high level classes should not be dependent on the implementations of the low-level classes. For example, if class A is dependent on class B, by applying the DIP there will be an interface for class B of which class A can create an instance off and use class B's implemented methods. This way, when there are new methods introduced, they will only be implemented into class B without the need to re-write code everywhere else in class A.
