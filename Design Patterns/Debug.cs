using System;   // Require for 'Console'

namespace BennyBroseph
{
    namespace Contextual
    {
        static class Debug
        {
            static public void Message(object a_Message)
            {
#if (!UNITY_EDITOR && DEBUG)
                Console.WriteLine(a_Message);
#elif UNITY_EDITOR
            Debug.Log(a_Message);
#endif
            }
            static public void Warning(object a_Message)
            {
#if (!UNITY_EDITOR && DEBUG)
                Console.WriteLine(a_Message + "...");
#elif UNITY_EDITOR
            Debug.LogWarning(a_Message + "...");
#endif
            }
            static public void Error(object a_Message)
            {
#if (!UNITY_EDITOR && DEBUG)
                Console.WriteLine("ERROR: " + a_Message + "!");
#elif UNITY_EDITOR
            Debug.LogError(a_Message + "!");
#endif
            }
        }
    }
}
