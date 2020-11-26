//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ParseFunctions;

    readonly struct SlnParser : IWfParser<SlnFile,Solution>
    {
        public IWfShell Wf {get;}

        public SlnParser(IWfShell wf)
        {
            Wf = wf;
        }

        public ParseResult2<SlnFile> Parse(in SlnFile src, out Solution dst)
            => parse(src, out dst);
    }
}