//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly partial struct Docs
    {
        public static string format(ContentKind src)
            => src.ToString().ToLower();

        public static string format(StructureKind src)
            => src.ToString().ToLower();

        public static IContentProvider content()
            => default(TableContentProvider);

    }
}