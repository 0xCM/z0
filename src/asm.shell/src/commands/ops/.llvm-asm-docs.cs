//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-asm-docs")]
        Outcome LlvmAsmDocs(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Sources().Dataset("llvm.tblgen.docs") + FS.file("X86.gen-instr-docs",FS.Txt);
            var current = TextLine.Empty;
            var prior = TextLine.Empty;
            var counter = 0u;
            var names = list<string>();
            Write(string.Format("Reading {0}", src.ToUri()));
            using var reader = src.Utf8LineReader();
            while(reader.Next(out current))
            {
                counter++;

                if(current.IsEmpty)
                    continue;

                var i = text.index(current.Content, "=====");
                if(i >= 0)
                {
                    names.Add(prior.Content);
                }

                prior = current;
            }

            Write(string.Format("Read {0} lines from {1}", counter, src.ToUri()));
            return result;
        }
    }
}