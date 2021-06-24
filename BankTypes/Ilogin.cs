using System;

namespace BankTypes
{
    public interface Ilogin
    {
        string Password { get; set; }
        DateTime Timestamp { get; set; }
        int Type { get; set; }
        string Username { get; set; }
    }
}