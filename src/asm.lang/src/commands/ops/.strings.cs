//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".strings")]
        Outcome CheckStringTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var name = "Counts";
            var input = @readonly(new string[]{"one","two","three", "four", "five", "six", "seven", "eight", "nine","ten"});
            var table = StringTables.create<byte>(name, input);
            var count = Require.equal(input.Length, (int)table.EntryCount);
            for(var i=0; i<count; i++)
            {
                var data = table[i];
                ref readonly var s0 = ref skip(input,i);
                var s1 = new string(data);
                Require.equal(s0,s1);
            }

            Write(table.Format());
            return result;
        }
   }
}