//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".stringtable")]
        Outcome Stringtable(CmdArgs args)
        {
            var result = Outcome.Success;
            var path = SouceWs().Path("strings", arg(args,0).Value, FS.Txt);
            var input = path.ReadLines().View;
            var name = path.FileName.WithoutExtension.Format();
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