//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".cc")]
        Outcome SymString(CmdArgs args)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var result = Outcome.Success;
            var conditions = Conditions.create();
            var buffer = alloc<Jcc8Conditions>(32);
            var count = Machines.jcc8(conditions,buffer);
            var output = slice(span(buffer),0, count);
            for(var i=0; i<count; i++)
            {
                ref readonly var info = ref skip(output,i);
                Write(info.Format(false));
                if(!info.Identical)
                    Write(info.Format(true));
            }

            return result;
        }
    }
}