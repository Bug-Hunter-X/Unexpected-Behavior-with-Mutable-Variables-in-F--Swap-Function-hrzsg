# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall in F# when working with mutable variables and swapping their values. The core issue lies in understanding how F# handles value vs reference semantics, especially when modifying variables within functions.

## The Problem

The `bug.fs` file contains a function that attempts to swap two mutable variables. However, depending on how you pass the variables to the function, the swap might not work as expected.

## The Solution

The `bugSolution.fs` file shows the corrected implementation using the `ref` keyword to pass variables by reference, correctly swapping the values. The explanation provides a clear understanding of how to prevent this issue in your own code.

## How to Reproduce

1. Clone this repository.
2. Open the files in an F# editor or IDE.
3. Run both files to observe the different outcomes.
