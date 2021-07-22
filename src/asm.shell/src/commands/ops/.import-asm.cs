//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-asm")]
        Outcome ImportAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var input = Files(FS.Asm);
            iter(input,ImportAsm);
            return result;
        }

        // .tool-out-files dumpbin *.asm
        void ImportAsm(FS.FilePath src)
        {
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(AsmParser.parse(line, out AsmLabel label, out AsmExpr expr))
                {
                    if(AsmParser.parse(label, out AsmOffsetLabel offset))
                        Write(string.Format("{0:x8}h {1}", offset.OffsetValue, expr));
                    else
                        Write(string.Format("{0}:{1}", label, expr));
                }
            }
        }
    }
}