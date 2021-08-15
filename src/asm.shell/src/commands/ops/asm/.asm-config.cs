//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asm-config")]
        Outcome AsmConfig(CmdArgs args)
        {
            var result = RunScript(AsmWs.Script("log-config"), out var response);
            if(result.Fail)
                return result;

            var src = Facets.parse(response);
            var count = src.Length;
            var vars = new CmdVar[count];
            ref var dst = ref first(vars);
            for(var i=0; i<count; i++)
            {
                ref readonly var facet = ref skip(src,i);
                seek(dst,i) = Cmd.var(facet.Key, facet.Value);
            }

            iter(vars, v => Write(v.Name,
                v.Evaluated ? string.Format("{0} (Evaluated)", v.Value) : string.Format("{0} (Symbolic)", v.Value))
                );

            return result;
        }
    }
}