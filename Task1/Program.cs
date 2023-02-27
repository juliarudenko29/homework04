int pow(int a, int b) {
    if (b == 0) {
        return 1;
    }

    var result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    } 

    return result;
}

var result = pow(3, 5);
System.Console.WriteLine(result);