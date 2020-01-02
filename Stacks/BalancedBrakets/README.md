﻿# Balanced Brackets


## Problem Statement: 

A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {},and ().

A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

By this logic, we say a sequence of brackets is balanced if the following conditions are met:

It contains no unmatched brackets.
The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
Given n strings of brackets, determine whether each sequence of 
brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.


INPUT:

The first line contains a string.

OUTPUT:

For each string, return YES or NO.



## Solution: 

Read each character from the input string and push it into a stack. While inserting each character check where the top most value in stack is the opposite bracket for the character to be inserted, if it is the same POP from stack. If at the end of the string the stack still contains elements then the brackets are not balanced.

Example
Input : "{[]}"

Currently Stack contains = { , [

The next value is ']'. As the top most value in stack is '[' which is the closing bracket of ']' POP the value from stack. 


     




