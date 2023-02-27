int totalSumOfNumber(int value) {
    var result = 0;
    int remainder;
    do {
        remainder = value % 10;
        value = value / 10;
        result += remainder;
    } while (value > 0);
    
    return result;
}

var res = totalSumOfNumber(452);
System.Console.WriteLine(res);

