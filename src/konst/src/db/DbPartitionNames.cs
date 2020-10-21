//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [LiteralProvider]
    public readonly struct DbNames
    {
        public const string Docs = "docs";

        public const string Tables = "tables";

        public const string Sources = "sources";

        public const string Stage = "stage";

        public const string Tools = "tools";

        public const string Jobs = "jobs";

        public const string Capture = "capture";

        public const string Logs = "logs";

        public const string Refs = "refs";

        public const string Events = "events";

        public const string Etl = "etl";

        public const string Queue = "queue";

        public const string Parsed = "parsed";

        public const string Il = "il";

        public const string Cil = "cil";

        public const string Asm = "asm";

        public const string Hex = "hex";

        public const string Extracts = "extracts";

        public const string Output = "output";

        public const string SubjectDelimiter = ".";

        public const string QualifiedSubject = "{0}" + SubjectDelimiter + "{1}";
    }
}