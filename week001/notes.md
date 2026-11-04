# Week 1 Notes

Rules: write from a blank file, pseudocode first, docs for syntax only, no AI.
Stuck rule: after 15 minutes stuck, write down what I tried, look up syntax only, redo from blank tomorrow.

## Ex01: Print 1 to 10
**Task:** Print the numbers 1 to 10, one per line, using a `for` loop.
**Variations:** odd numbers from 1 to 20, a countdown from 10 to 1, a times table for a number the user enters.

- Pseudocode:I used for loop statement and used i = 0; < = 10; 0++ for the main task that is
- Time taken:Oct. 27, 2026 3:30PM
- Looked anything up? (what): how does for loop statement works via w3schools
- Where I got stuck:times table for a number the user enters because of having a trouble doing it repeatedly and did not know how to use tryparse properly
- Hand trace done? (yes/no): no

## Ex02: Even or odd
**Task:** Read a number from the console. Print "even" or "odd".
**Variations:** handle 0 and negative numbers, and re-ask if the input isn't a number.

**Status:** Core task done. 0/negatives: done (tested 4, 7, 0, -3, -4). Re-ask loop: not done yet (needs `while`); right now bad input prints a message and the program ends.

- Pseudocode: ask for a number; if it converts to a whole number: if it is divisible by 2 print even, otherwise print odd; if it doesn't convert, print a message. (Warm-up, now commented out in the file: a for loop from 1 to 20 printing even/odd for each.)
- Time taken: 30 mins total (Oct 28 and Nov 3, over few sessions)
- Looked anything up? (what): for loop on W3Schools; int.TryParse
- Where I got stuck: (1) didn't know how to test even/odd and whether there was a function for it (`% 2 == 0` works); (2) the loop started at 0 and stopped at 19 instead of 1 to 20, fixed with `x = 1` and `x <= 20`; (3) first version used `decimal` and only echoed the number instead of testing it; (4) the first version of the core task read the number but never tested it, and I had to connect the user's number to the even/odd check; (5) forgot the syntax when I came back the next day (Oct 29) and had to re-derive it by trial and error
- Hand trace done? (yes/no): yes for the loop; yes, after the fact, for the final version (traced 4, 7, 0, -3, -4)

## Ex03: FizzBuzz   
**Task:** For each number from 1 to n, print "Fizz" if it's divisible by 3, "Buzz" if by 5, "FizzBuzz" if by both, otherwise the number.
**Variations:** let the user enter n, and count how many Fizz, Buzz and FizzBuzz lines there were.

- Pseudocode (written after coding): read n; set three counters to 0; for each i from 1 to n: if divisible by 3 and 5 then print FizzBuzz and add 1 to that counter, else if divisible by 3 then print Fizz and count it, else if divisible by 5 then print Buzz and count it, else print i; after the loop print the three totals
- Time taken: about 120 min of coding, spread over several days (Oct 28 to Nov 3)
- Looked anything up? (what): for loop and if/else on W3Schools; Enumerable.Range (turned out not to be needed)
- Where I got stuck: (1) tested `number` instead of `i` inside the loop; (2) put the FizzBuzz check last so 15 printed Fizz; (3) wasn't sure where to declare the counters (before the loop so they keep their values, and so they're still in scope for the totals)
- Hand trace done? (yes/no): No

## Ex04: Grade classifier
**Task:** Read a score from 0 to 100 and print a letter grade (A: 90 to 100, B: 80 to 89, C: 70 to 79, D: 60 to 69, F: below 60).
**Variations:** reject scores below 0 or above 100; check the boundaries (90, 89, 80, 79, 60, 59, 0, 100); re-ask until valid (needs `while`, not done yet).

- Pseudocode (from my code): ask for a score; if it converts to a whole number: if it is below 0 or above 100 print an invalid message; else if 100 print a perfect-grade message; else if 90 or more print A; else if 80 or more print B; else if 70 or more print C; else if 60 or more print a grade; otherwise print a fail message; if it doesn't convert, print a message
- Time taken: 20 mins (Nov. 4, 2026)
- Looked anything up? (what): Operations in W3Schools
- Where I got stuck: found a bug where after entering above 100 plus, 0, and negative numbers so I have to look up how to use the operator properly in W3Schools.
- Hand trace done? (yes/no): yes (trace 95, 72, 59, 150 and the boundaries)