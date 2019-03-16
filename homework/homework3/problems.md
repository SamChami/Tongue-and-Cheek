##  Problems from Ch 7 and 8
####  Sam Chami, Merci Magallanes, and John Scott

###  Problem 7.1, Stephens page 169

The greatest common divisor (GCD) of two integers is the largest integer that evenly divides them both. For example, the GCD of 84 and 36 is 12, because 12 is the largest integer that evenly divides both 84 and 36. You can learn more about the GCD and the Euclidean algorithm, which you can find at en.wikipedia.org/wiki/Euclidean_algorithm. (Don't worry about the code if you can't understand it. Just focus on the comments.)(Hint: It should take you only a few seconds to fix these comments. Don't make a career out of it.)
```
         // Use Euclid's algorithm to calculate the GCD.
         // See en.wikipedia.org/wiki/Euclidean_algorithm.
         private long GCD( long a, long b )
         {
            a = Math.abs( a );
            b = Math.abs( b );

            for( ; ; )
            {
               long remainder = a % b;
               if (remainder == 0) return b;
               a = b;
               b = remainder;
            };
         }
```
>  Referencing where to learn more about the used algorithm and getting rid of obvious comments that clutter the code and don't add any explanation of why the code does what it does is better commented code.

###  Problem 7.2, Stephens page 170

Under what two conditions might you end up with the bad comments shown in the previous code?
>  The two conditions why the original GCD code ended up with bad comments are the programmer may have done a top-down design and the programmer added the comments after writing the code. In the first scenario, the programmer may have taken it to its logical conclusion where the code is described in excruciating detail. That’s good programming practice, but it can result in the kinds of redundant comments in the previous example because each comment describes a code statement. In the second scenario, it’s easy to just say what each line of code does and not why it is doing it after the code is written.

###  Problem 7.4, Stephens page 170

How could you apply offensive programming to the modified code you wrote for exercise 3? [Yes, I know that problem wasn't assigned, but if you take a look at it you can still do this exercise.]
>  The validation code written for Exercise 3 is already fairly offensive. It validates the inputs and the result, and the `Debug.Assert` method throws an exception if there is a problem.

###  Problem 7.5, Stephens page 170

Should you add error handling to the modified code you wrote for Exercise 4?
>  No because it would be better if the calling code handled any errors. As it is, if the code throws any exceptions, they are passed up to the calling code so that they can be handled there. Therefore there is no need to add error handling code here.

###  Problem 7.7, Stephens page 170

Using top-down design, write the highest level of instructions that you would use to tell someone how to drive your car to the nearest supermarket. (Keep it at a very high level.) List any assumptions you make.
>  High Level instructions to get to nearest supermarket:
> * a. Go outside.
> * b. Open car.
> * c. Start car.
> * d. Back out of driveway.
> * e. Turn to the right and go down the street until the stop sign.
> * f. Turn right. Drive until the first traffic light.
> * g. Turn left. Drive to the supermarket parking lot on the right.
> * h. Turn into the supermarket parking lot.
> * i. Find an empty parking space and park in it.
> * j. Stop the car and get out.
> * k. Go inside supermarket.

>  Assumptions:
> * a. The car is outside in driveway.
> * b. The car is shut.
> * c. The car is functional.
> * d. There’s nothing behind the car when you pull out of driveway.
> * e. No cars driving down street
> * f. Other cars and people obey traffic laws.
> * g. There are empty parking spaces in the supermarket parking lot.
> * h. The supermarket is open.

###  Problem 8.1, Stephens page 199

Two integers are ***relatively prime*** (or ***coprime***) if they have no common factors other than 1. For example, 21 = 3 X 7 and 35 = 5 X 7 are ***not*** relatively prime because they are both divisible by 7. By definition -1 and 1 are relatively prime to every integer, and they are the only numbers relatively prime to 0.

Suppose you've written an efficient `IsRelativelyPrime` method that takes two integers between -1 million and 1 million as parameters and returns `true` if they are relatively prime. Use either your favorite programming language or pseudocode (English that sort of looks like code) to write a method that tests the `IsRelativelyPrime` method. (Hint: You may find it useful to write another method that also tests two integers to see if they are relatively prime.)
>  TODO

###  Problem 8.3, Stephens page 199

What testing techniques did you use to write the test method in Exercise 1? (Exhaustive, black-box, white-box, or gray-box?) Which ones could you use and under what circumstances? [Please justify your answer with a short paragraph to explain.]
>  TODO

###  Problem 8.5, Stephens page 199 - 200

the following code shows a C# version of the `AreRelativelyPrime` method and the `GCD` method it calls.
```
         // Return true if a and b are relatively prime.
         private bool AreRelativelyPrime( int a, int b )
         {
            // Only 1 and -1 are relatively prime to 0.
            if( a == 0 ) return ((b == 1) || (b == -1));
            if( b == 0 ) return ((a == 1) || (a == -1));

            int gcd = GCD( a, b );
            return ((gcd == 1) || (gcd == -1));
         }

         // Use Euclid's algorithm to calculate the
         // greatest common divisor (GCD) of two numbers.
         // See https://en.wikipedia.org/wiki/Euclidean_algorighm
         private int GCD( int a, int b )
         {
            a = Math.abs( a );
            b = Math.abs( b );

            // if a or b is 0, return the other value.
            if( a == 0 ) return b;
            if( b == 0 ) return a;

            for( ; ; )
            {
               int remainder = a % b;
               if( remainder == 0 ) return b;
               a = b;
               b = remainder;
            };
         }
```
The `AreRelativelyPrime` method checks whether either value is 0. Only -1 and 1 are relatively prime to 0, so if a or b is 0, the method returns `true` only if the other value is -1 or 1.

The code then calls the `GCD` method to get the greatest common divisor of `a` and `b`. If the greatest common divisor is -1 or 1, the values are relatively prime, so the method returns `true`. Otherwise, the method returns `false`.

Now that you know how the method works, implement it and your testing code in your favorite programming language. Did you find any bugs in your initial version of the method or in the testing code? Did you get any benefit from the testing code?
>  TODO

###  Problem 8.9, Stephens page 200

Exhaustive testing actually falls into one of the categories black-box, white-box, or gray-box. Which one is it and why?
>  TODO

###  Problem 8.11, Stephens page 200

Suppose you have three testers: Alice, Bob, and Carmen. You assign numbers to the bugs so the testers find the sets of bugs {1, 2, 3, 4, 5}, {2, 5, 6, 7}, and {1, 2, 8, 9, 10}. How can you use the Lincoln index to estimate the total number of bugs? How many bugs are still at large?
>  TODO

###  Problem 8.12, Stephens page 200

What happens to the Lincoln estimate if the two testers don't find any bugs in common? What does it mean? Can you get a "lower bound" estimate of the number of bugs?
>  TODO
