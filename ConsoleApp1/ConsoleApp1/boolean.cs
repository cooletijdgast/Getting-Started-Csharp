/**
 Ip must contain 4 numbers.
 Each number must not contain leading zeroes
 Each number must be in range of 0 to 255

if ip has 4 numbers
and 
if number does not containt leading zeroes
and
if number is in range of 0 to 255

    then ip is valid

    else ip is invalid

 */

string ipv4Input = "1.1.1.255";
if (validateLength())
{
    Console.WriteLine(ipv4Input);
}


Boolean validateLength()
{
    string[] address = ipv4Input.Split('.');
    if (address.Length == 4 && validateNumber(address) && validRange(address))
    {
        return true;
    }
    return false;
}

Boolean validateNumber(String[] address)
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith('0'))
        {
            return false;
        }
    }
    return true;
}

Boolean validRange(String[] address)
{
    foreach (string numberString in address)
    {
        int number = int.Parse(numberString);
        if (number < 0 || number > 255)
        {
            return false;
        }
    }
    return true;
}