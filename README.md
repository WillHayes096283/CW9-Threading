# CW9-Threading
* Date: 3/1/2023
* Name: William Hayes

## Purpose
The purpose of this program is to demonstrate the use of threading by creating a program that calculates pi values using the Monte Carlo method. First, the program takes the user's input: the number of throws made at a circle that each thread should make and the total number of threads. Next, the class FindPiThreads generates puesdo-random (X, Y) coordinates to find their hypotenuse. If the hypotenuse is less than or equal to 1, then a throw made at a circle hit the target. The class counts up the total throws that made it into the circle for each thread and divides it by the total number of throws attempted before multipling the resulting value by 4. Thus, after this evaluation algorithm is completed the resulting values should be roughly equal to the value of pi.

## Compliation Instructions
1. Clone this repo in Visual Studios 2020, or download the files and run the solution file.
2. Click the Start button in the top menu to run the program.
3. Enter the respective integer values for the number of throws to simulate and the total number of threads to simulate.

## Notes
* Resolved some issues with throwDarts() method, I forgot to calculate the hypotenuse and made X and Y integers instead of doubles.
