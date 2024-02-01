using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CustomInterpolationHandler
{

    [InterpolatedStringHandler]
    public ref struct LogInterpolatedStringHandler
    {
        // Storage for the built-up string
        StringBuilder builder;

        public LogInterpolatedStringHandler(int literalLength, int formattedCount)
        {
            builder = new StringBuilder(literalLength);
            Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
        }

      


    }
}
