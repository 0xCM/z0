//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".xed-datasets")]
        Outcome XedDatasets(CmdArgs args)
        {
            const string RenderPattern = "{0,-32} | {1}";
            var result = Outcome.Success;
            var datasets = IntelXed.datasets();
            var count = datasets.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var ds = ref skip(datasets,i);
                var fmt = string.Format(RenderPattern, ds.Identifier, ds.Name);
                Write(fmt);
            }

            return result;
        }
    }
}