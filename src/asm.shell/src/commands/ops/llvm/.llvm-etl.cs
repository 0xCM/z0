//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.llvm;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-etl")]
        Outcome RunLlvmEtl(CmdArgs args)
        {
            var result = LlvmEtl.RunEtl(out var datasets);
            if(result.Fail)
                return result;

            // var fields = datasets.AsmDefFields;
            // var count = fields.Length;
            // for(var i=0; i<count; i++)
            // {
            //     ref readonly var field = ref skip(fields,i);
            //     Write(field.Format());
            // }

            return result;
        }

        [CmdOp(".llvm-list-gen")]
        Outcome LlvmListGen(CmdArgs args)
            => LlvmEtl.GenLists();
    }
}