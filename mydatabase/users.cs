using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mydatabase
{
    public class Users
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string email { get; set; }
        public string ulica { get; set; }
        public string miasto { get; set; }
        public string kodPocztowy { get; set; }
        public int telefon { get; set; }

        public static string FormatPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"[^\d]");
            phone = regex.Replace(phone, "");
            phone = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{3})", "$1-$2-$3");
            return $" +48 {phone}";
        }

        public override string ToString()
        {
            return $"{imie, - 15} ||" +
                $" {nazwisko, -15} ||" +
                $" {email, - 35} ||" +
                $" {ulica, - 30} ||" +
                $" {miasto, - 20} ||" +
                $" {kodPocztowy, - 7} ||" +
                $" {FormatPhoneNumber(telefon.ToString()),-10} ";
        }
    }
}
