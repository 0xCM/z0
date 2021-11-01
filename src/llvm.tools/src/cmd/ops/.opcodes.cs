//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    partial class LlvmCmd
    {
        [CmdOp(".opcodes")]
        Outcome EmitOpCodes(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = llvm.MC.opcodes().View;
            var dst = LlvmData.TablePath<OpCodeSpec>();
            TableEmit(src, OpCodeSpec.RenderWidths, dst);
            return result;
        }

        [CmdOp(".asmid")]
        public Outcome ShowAsmIdList(CmdArgs args)
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