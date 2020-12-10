//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    public struct Pdb2Xml : IToolModel<Pdb2Xml>
    {
        public const string Name = "pdb2xml";

        public const char Delimiter='/';

        public const string Usage = "pdb2xml <PEFile | DeltaPdb> [/out <output file>] [/tokens] [/methodSpans] [/delta] [/srcsvr] [/sources] [/native]";

        public FS.FilePath SrcPath;

        public FS.FilePath DstPath;

        public bool Tokens;

        public bool MethodSpans;

        public bool Delta;

        public bool Sources;

        public bool Native;
    }
}