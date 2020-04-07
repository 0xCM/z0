//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        public static string Format(this BlockedKind k)
            => k != 0 ? k.ToString() : string.Empty;
    }
}