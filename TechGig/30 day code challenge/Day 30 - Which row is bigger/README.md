# Which row is bigger? (100 Marks)<br/>
For this challenge, you need to take a matrix as an input from the stdin, identify which row has the maximum sum of the digits.For example, in the below matrix<br/>
1 2 3<br/>
4 5 6<br/>
7 8 9<br/>
Row 1 is 1,2,3<br/>
Row 2 is 4,5,6<br/>
Row 3 is 7,8,9<br/>
<br/>
### Input Format<br/>
The first line contains two integers N, M denoting the number of rows and columns respectively.<br/>
Each of the 'N' Next line contains M integers each.<br/>
<br/>
### Constraints<br/>
1 < (n,m) < 100<br/>
<br/>
### Output Format<br/>
If the sum of the digits of row 1 found to be greater than that of row 2 and row 3, then print 'Row 1' to the stdout. If the sum of all the rows found to be equal, then print 'Equal' to the stdout. <br/>
<br/>
## Sample TestCase 1<br/>
<br/>
### Input<br/>
3 4<br/>
2 3 4 2<br/>
1 4 6 5<br/>
4 8 9 6<br/>
<br/>
### Output<br/>
Row 3<br/>