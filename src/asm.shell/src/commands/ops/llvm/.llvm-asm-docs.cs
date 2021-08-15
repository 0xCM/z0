//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-asm-docs")]
        Outcome LlvmAsmDocs(CmdArgs args)
        {
            const string AsmStringMarker = "Assembly string (intel):";
            const string FlagsMarker = "Flags:";
            const string ImplicitUsesMarker = "Implicit uses:";
            const string ImplicitDefsMarker = "Implicit defs:";
            const string PredicateMarker = "Predicates:";
            const string UseMarker = "* USE";
            const string ConstraintsMarker = "Constraints:";

            var result = Outcome.Success;
            var src = DataSources.Datasets("llvm.tblgen.docs") + FS.file("X86.gen-instr-docs",FS.Txt);
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

            Write(string.Format("Found {0} content sections in {1}", names.Count, src.ToUri()));
            return result;
        }
    }
}