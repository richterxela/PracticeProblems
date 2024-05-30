using System;
using System.Text;

namespace TestProblems
{

    public class MessageNotification
    {
        public void Main()
        {
            Console.WriteLine(MessageNotif("test string number one", 10));
            Console.WriteLine(MessageNotif("qwer asdfasdf zxdfzxcvzxcv poiuopiupoiuopiupoiu l;kj;lkjl;kjljk; .,mn,.mn.,mn,.mn,m.n,.mn", 40));
            Console.WriteLine(MessageNotif("", 10));
            Console.WriteLine(MessageNotif("a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z a b c d e f g h i j k l m n o p q r s t u v w x y z", 50));



        }
        //Create a function such that a string message will be made shorter than a provided length K
        //If the message does have to be shortened then append a " ..." to the end of it while also maintaining the length requirement
        private static string MessageNotif(string message, int K)
        {
            if (message.Length <= K) return message;

            //if (message.Length < 3) return "...";

            // take the K value from the message length and subtract
            // After subtracting we count backwards until we have a space
            // Once we hit a space we check if we can add in the "...", then do so, otherwise remove until next space

            StringBuilder sb = new StringBuilder();
            sb.Append(message.Substring(0, K));

            Console.WriteLine(sb.ToString());

            int j = sb.Length - 1;
            while (j >= 0 && sb[j] != ' ')
            {
                sb.Remove(j, 1);
                j--;
            }

            sb.Append("...");


            return sb.ToString();





        }
    }
}
