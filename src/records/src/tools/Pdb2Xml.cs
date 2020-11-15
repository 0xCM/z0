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

        [Position(0), Meaning("The input file path")]
        public FS.FilePath SrcPath;

        [Name("out"), Meaning("The output file path")]
        public FS.FilePath DstPath;

        [Name("tokens")]
        public bool Tokens;

        [Name("methodSpans")]
        public bool MethodSpans;

        [Name("delta")]
        public bool Delta;

        [Name("sources")]
        public bool Sources;

        [Name("native")]
        public bool Native;
    }
}