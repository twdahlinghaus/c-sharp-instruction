using System;

namespace lists_and_maps {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcom to Lists and Maps!");

            List<String> singers = new ArrayList<>();
            singers.Add("Bob Marley");
            singers.Add("Dave Grohl");
            singers.Add("Freddy Mercury");
            singers.Add("Bob Dylan");

            singers.Sort();

            foreach (String item in singers) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Bye!");
        }
    }
}
