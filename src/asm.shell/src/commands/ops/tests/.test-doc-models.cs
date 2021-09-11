//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class AsmCmdService
    {

        [CmdOp(".test-doc-models")]
        Outcome TestDocModels(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = FS.path(@"J:\source\llvm\llvm-project\llvm\lib\MC\MCParser\AsmParser.cpp");

            var count = FS.linecount(src);
            Write(count);
            var doc = DocModels.unicode(src);
            var reader = doc.CreateReader();
            Write(reader.Count(Chars.NL));



            return result;
        }

    }
}