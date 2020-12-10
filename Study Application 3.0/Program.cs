/*
Grace Anders
10/22/2020
Branching (Study Application)

Stack Overflow: https://stackoverflow.com/questions/12180038/randomly-shuffle-a-list
Stack Overflow: https://stackoverflow.com/questions/43294313/using-streamreader-to-read-lines-as-defined-by-other-lines
 */

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Study_Application_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowHeight = LargestWindowHeight;
            WindowWidth = LargestWindowWidth;

            Title = "Study Application By: Grace";
            string TitleText = "";
            TitleText = @"
                +------------+ +------------+ +--+      +--+ +---------+    +-+        +-+        +---------+  +---------+    +---------+
                |            | |            | |  |      |  | |          ++  |  +      +  |      +            + |          ++  |          ++
                |  +---------+ +----+  +----+ |  |      |  | |  +----+    +  +  +    +  +       |   +----+   | |  +-----+   + |  +-----+   +
                |  |                |  |      |  |      |  | |  |     -+  |   +  +  +  +        |  +      +  | |  |      +  | |  |      +  |
                |  +---------+      |  |      |  |      |  | |  |      |  |    +  ++  +         |  |      |  | |  |      +  | |  |      +  |
                |            |      |  |      |  |      |  | |  |      |  |     +    +          |  +------+  | |  +-----+   + |  +-----+   +
                +---------+  |      |  |      |  |      |  | |  |      |  |      +  +           |            | |          ++  |          ++
                          |  |      |  |      |  |      |  | |  |      |  |      |  |           |   +----+   | |  +------+    |  +------+
                          |  |      |  |      |  |      |  | |  |     ++  |      |  |           |  +      +  | |  |           |  |
                +---------+  |      |  |      |  +------+  | |  +----+    +      |  |           |  |      |  | |  |           |  |
                |            |      |  |      |            | |          ++       |  |           |  |      |  | |  |           |  |
                +------------+      +--+      +------------+ +---------+         +--+           +--+      +--+ +--+           +--+
                
                                                                       By: Grace Anders
            
            ";
            WriteLine(TitleText);
            App app = new App();

            
        }
    }
}
