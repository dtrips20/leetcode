using System;
using System.Collections.Generic;

/*
Every email consists of a local name and a domain name, separated by the @ sign.

For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name.

Besides lowercase letters, these emails may contain '.'s or '+'s.

If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.  For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)

If you add a plus ('+') in the local name, everything after the first plus sign will be ignored. This allows certain emails to be filtered, for example m.y+name@email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)

It is possible to use both of these rules at the same time.

Given a list of emails, we send one email to each address in the list.  How many different addresses actually receive mails? 
 * 
Example 1:

Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
Output: 2
Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails
 * 
 * 
 */
namespace NumUniqueEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

           // string[] emails = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
           // int i = p.NumUniqueEmails(emails);

            string[] emails1 = { "testemail@leetcode.com", "testemail1@leetcode.com", "testemail+david@lee.tcode.com" };
            int i = p.NumUniqueEmails(emails1);

            Console.WriteLine(i);
        }



        public int NumUniqueEmails(string[] emails)
        {
            List<String> finalEmails = new List<string>();
            

            for (int i = 0; i < emails.Length; i++)
            {

                int indexOfPlus = emails[i].IndexOf("+");
                int indexofAtTheRate = emails[i].IndexOf("@");
                string appendedEmail = emails[i];
                if (indexOfPlus >= 0)
                {
                    appendedEmail = appendedEmail.Remove(indexOfPlus, indexofAtTheRate - indexOfPlus);
                }
                string[] email = appendedEmail.Split('@');

                string withOutDot = email[0];
                while (withOutDot.IndexOf('.') >= 0)
                {
                    withOutDot = withOutDot.Remove(withOutDot.IndexOf('.'), 1);
                }

                string finalEmail = withOutDot +"@"+ email[1];

                if (!finalEmails.Contains(finalEmail))
                {
                    finalEmails.Add(finalEmail);
                }
                
                
            }

            return finalEmails.Count;
        }
    }
}
