//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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

        public const string refs = nameof(refs);

        public const string refdata = nameof(refdata);

        public const string events = nameof(events);

        public const string etl = nameof(etl);

        public const string queue = nameof(queue);

        public const string parsed = nameof(parsed);

        public const string il = nameof(il);

        public const string cil = nameof(cil);

        public const string cildata = nameof(cil) + delimiter + data;

        public const string asm = nameof(asm);

        public const string hex = nameof(hex);

        public const string extracts = nameof(extracts);

        public const string output = nameof(output);

        public const string delimiter = ".";

        public const string qualified = "{0}" + delimiter + "{1}";

        public const string notebooks = nameof(notebooks);

        public const string indices = nameof(indices);

        public const string imm = nameof(imm);

        public const string builds = nameof(builds);

        public const string build = ".build";

        public const string tmp = nameof(tmp);

        public const string data = nameof(data);

        public const string dumps = nameof(dumps);

        public const string bin = nameof(bin);

        public const string source = nameof(source);
    }
}