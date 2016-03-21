using System;
using System.Windows.Forms;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Form App = new Form();

            App.KeyPreview = true;

            BennyBroseph.Contextual.InputManager.self.Init(App);
            BennyBroseph.Contextual.InputManager.self.AddOnKeyDown(OnKeyDown);

            BennyBroseph.Publisher.self.Subscribe("Event",
                delegate (string a_String, object a_Param) { Console.WriteLine("Event"); });

            BennyBroseph.Publisher.self.Broadcast("Event", null);

            Application.Run(App);
        }

        static void OnKeyDown(BennyBroseph.Contextual.Keys a_Key)
        {
            Console.WriteLine(a_Key);
        }
    }
}
