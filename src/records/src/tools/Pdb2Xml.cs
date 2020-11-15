//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;

    [Tool(Name, Delimiter, Usage)]
    public struct Pdb2Xml : IToolModel<Pdb2Xml>
    {
        public const string Name = "pdb2xml";

        public const char Delimiter='-';

        public const string Usage = "pdb2xml <PEFile | DeltaPdb> [/out <output file>] [/tokens] [/methodSpans] [/delta] [/srcsvr] [/sources] [/native]";

        [Slot(0), Meaning("The input file path")]
        public FS.FilePath SrcPath;

        [Slot("out"), Meaning("The output file path")]
        public FS.FilePath DstPath;

        [Slot("tokens")]
        public bool Tokens;

        [Slot("methodSpans")]
        public bool MethodSpans;

        [Slot("delta")]
        public bool Delta;

        [Slot("sources")]
        public bool Sources;

        [Slot("native")]
        public bool Native;
    }
}