# Stock Span Problem

## Problem Statement

The stock span problem is a financial problem where we have a series of n daily price quotes for a stock and we need to calculate span of stock’s price for all n days.
The span Si of the stock’s price on a given day i is defined as the maximum number of consecutive days just before the given day, for which the price of the stock on the current day is less than or equal to its price on the given day.
For example, if an array of 7 days prices is given as {100, 80, 60, 70, 60, 75, 85}, then the span values for corresponding 7 days are {1, 1, 1, 2, 1, 4, 6}

https://www.geeksforgeeks.org/the-stock-span-problem/

## Solution 

Create three stacks : 

1. A trasaction stack to which the given price for each day is added after required checks.
2. A stack to keep track of prices that are lower than price of given day and push it back to inital stack
3. The result stack storing the Stock Span. 


For each price check if the price on the give day is greater than the value in the top of stack, if not push the new value into the stack, if yes, Pop the top most stack and push it to the 2nd stack. Repeat this process till the price of the given day is not greater than the value at top of stack and then push the price to 1st stack. 
The number of entries in the 2nd Stack will be the Stock span for the price on the given day, take the count of stack and push it to the result stack. Then empty the 2nd stack and push it back to the 1st stack.

Looping through all the prices will provide the result stack having the Stock Span for each price for the given day. 





