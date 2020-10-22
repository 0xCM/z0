//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;

    readonly struct ApiNames
    {
        public const string Signatures = signatures;

        const string workers = nameof(workers);

        public const string Cmd = cmd + dot + core;

        public const string CmdParse = cmd + dot + "parse";

        const string parsers = nameof(parsers);

        public const string ParseDomain = parsers + dot + "domain";

        public const string FilePathParser = parsers + dot + files + dot + "paths";

        public const string EnumCatalogs = enums + dot + catalogs;
    }
}