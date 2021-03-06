//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static CheckInvariant;

    public class t_cmd_parse : t_symbolic<t_cmd_parse>
    {
        public static string[] Cases = new string[]{
            "cl.exe /c /I\"J:\\LANG\\TOOLS\\LLVM-PROJECT\\BUILD\\BENCHMARKS\" /I\"J:\\LANG\\TOOLS\\LLVM-PROJECT\\LLVM\\BENCHMARKS\" /I\"J:\\LANG\\TOOLS\\LLVM-PROJECT\\BUILD\\INCLUDE"
            };

        public void t_cmd_parse_01()
        {
            var src = Cases[0];
            var result = CmdParser.parse(src);
            require(result);
            Trace(result.Value.Format());
        }
    }
}