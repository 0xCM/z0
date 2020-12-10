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
        public const string docs = nameof(docs);

        public const string lists = nameof(lists);

        public const string tables = nameof(tables);

        public const string sources = nameof(sources);

        public const string stage = nameof(stage);

        public const string tools = nameof(tools);

        public const string jobs = nameof(jobs);

        public const string capture = nameof(capture);

        public const string logs = nameof(logs);

        public const string Refs = "refs";

        public const string Events = "events";

        public const string etl = nameof(etl);

        public const string Queue = "queue";

        public const string Parsed = "parsed";

        public const string Il = "il";

        public const string Cil = "cil";

        public const string Asm = "asm";

        public const string hex = nameof(hex);

        public const string extracts = nameof(extracts);

        public const string output = nameof(output);

        public const string SubjectDelimiter = ".";

        public const string QualifiedSubject = "{0}" + SubjectDelimiter + "{1}";

        public const string notebooks = nameof(notebooks);

        public const string indices = nameof(indices);

        public const string imm = "asm.imm";

        public const string builds = "builds";
    }
}