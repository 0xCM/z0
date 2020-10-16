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
    }
}