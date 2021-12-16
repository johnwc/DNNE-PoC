using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestHook
    {
        [UnmanagedCallersOnly(EntryPoint = "FancyName")]
        [DNNE.C99DeclCode("#include <hooks/hooks.h>")]
        public static int MyExport(int a)
        {
            return a;
        }
    }
}
