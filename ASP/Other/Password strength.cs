using System.Text.RegularExpressions;
private int checkPassword(string password)
 {
        int strong = 0;
        Regex specialWord= new Regex("[~!@#$%_^&*()=+[\\]{}''\";:/?.,><`|！·￥…—（）\\-、；：。，》《]");
        Regex CapitalW= new Regex("[A-Z]");
        Regex sWord= new Regex("[a-z]");
        Regex num= new Regex("[0-9]");
        if (specialWord.IsMatch(password) == true)
            strong++;
        if (CapitalW.IsMatch(password) == true)
            strong++;
        if (sWord.IsMatch(password) == true)
            strong++;
        if (num.IsMatch(password) == true)
            strong++;
        return strong;
    }

