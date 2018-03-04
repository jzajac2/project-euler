/*Each new term in the Fibonacci sequence is generated by adding the previous two terms.
By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
find the sum of the even-valued terms.
*/

function evenFibonacciNumbers(doNotExceed) {
	
	var sum = 0;
	var a = 1;
	var b = 1;
	var c = a + b;
	
	while (c < doNotExceed) {
		sum += c; 
		a = b + c;
		b = c + a;
		c = a + b; //every third fib num is even, so just add those
	}
	
 	print(sum);
 	
}

evenFibonacciNumbers(4000000);