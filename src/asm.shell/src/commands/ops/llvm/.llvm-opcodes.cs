//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using llvm;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-ocspecs")]
        Outcome LlvmOcSpecs(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = llvm.MC.opcodes().View;
            var formatter = Tables.formatter<OpCodeSpec>(OpCodeSpec.RenderWidths);
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                Write(formatter.Format(code));
            }

            return result;
        }

        [CmdOp(".llvm-ocstrings")]
        public Outcome LlvmOcStrings(CmdArgs args)
        {
            var result = Outcome.Success;
            var strings = llvm.Strings.OpCodes;
            var count = strings.EntryCount;
            for(ushort i=0; i<count; i++)
            {
                Write(string.Format("{0:D5}: '{1}'", i, text.format(strings[i])));
            }

            return result;
        }
    }
}