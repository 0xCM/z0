//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct WsAtoms
    {
        public const string tools = "tools";

        public const string asm = "asm";

        public const string tables = "tables";

        public const string projects = "projects";

        public const string sources = "sources";

        public const string imports = "imports";

        public const string logs = nameof(logs);

        public const string gen = "gen";

        public const string control = nameof(control);

        public const string config = nameof(config);

        public const string docs = nameof(docs);

        public const string scripts = nameof(scripts);

        public const string samples = nameof(samples);

        public const string inventory = nameof(inventory);

        public const string dumps = nameof(dumps);

        public const string lang = nameof(lang);

        public const string output = ".out";

        public const string src = nameof(src);

        public const string obj = nameof(obj);

        public const string exe = nameof(exe);

        public const string bin = nameof(bin);

        public const string list = nameof(list);

        public const string lists = nameof(lists);

        public const string dis = nameof(dis);

        public const string admin = ".admin";

        public const string queries = nameof(queries);

        public const string api = nameof(api);
    }
}
