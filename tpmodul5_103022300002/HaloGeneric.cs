using System;

namespace tpmodule5_103022300002  // Sesuaikan dengan namespace project
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
}
