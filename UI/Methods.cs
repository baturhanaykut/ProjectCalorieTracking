using System.Security.Cryptography;
using Entities.Enums;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Text;
using System.Text.RegularExpressions;

namespace UI;

internal static class Methods
{
    internal static bool CheckForUpperCase(string sifre)
    {
        int count = 0;
        foreach (char item in sifre)
        {
            if (char.IsUpper(item))
            {
                count++;
            }
        }
        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    internal static bool CheckForLowerCase(string sifre)
    {
        int count = 0;
        foreach (char item in sifre)
        {
            if (char.IsLower(item))
            {
                count++;
            }
        }

        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    internal static bool CheckForSpecialCharacter(string sifre)
    {
        string specialCharacters = "!@#$%^&*()_+{}|:<>?-=[];',./";
        int count = 0;
        foreach (char item in sifre)
        {
            if (specialCharacters.Contains(item))
            {
                count++;
            }
        }
        if (count >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public static bool IsValidEmail(string email)
    {
        Regex emailRegex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", RegexOptions.IgnoreCase);
        return emailRegex.IsMatch(email);
    }

    public static string Sha256_hash(string sifre)
    {
        using (SHA256 hash = SHA256Managed.Create())
        {
            return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
        }
    }

   


}




