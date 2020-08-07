# Comparison between diagonals (100 Marks)<br/>
For this challenge, you need to take a matrix as an input from the stdin , calculate the sum of the digits for each diagonal and compare them.For example,<br/>
in the below matrix<br/>
1 2 3<br/>
4 5 6<br/>
7 8 9<br/>
Diagonal 1 is 1,5,9.<br/>
Diagonal 2 is 3,5,7.<br/>
<br/>
### Input Format<br/>
A matrix is to be taken as input from stdin.On first line you need to tell that how many rows and columns your matrix need to have and these values should be separated by space.<br/>
<br/>
### Constraints<br/>
1 < (n,m) < 100<br/>
<br/>
### Output Format<br/>
If sum of digits for diagonal 1 is found to be greater than diagonal 2, then print 'Diagonal 1' to the stdout. If sum of digits for diagonal 2 is found to be greater than diagonal 1, then print 'Diagonal 2' to the stdout. If both of the diagonal found to be equal, then print 'Equal' to the stdout.<br/>
<br/>
## Sample TestCase 1<br/>
<br/>
### Input<br/>
3 3<br/>
2 3 4<br/>
1 4 6<br/>
7 8 9<br/>
<br/>
### Output<br/>
Equal<br/>
<br/>
## Explanation<br/>
<br/>
The sum of the digits for the diagonal 1 is 15 and that of diagonal 2 is also same i.e 15. Thus, print 'Equal' to the stdout.<br/>