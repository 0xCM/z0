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
        public static string format(DocContentKind src)
            => src.ToString().ToLower();

        public static string format(DocStructureKind src)
            => src.ToString().ToLower();

        public static IContentProvider content<T>()
            where T : IContentProvider, new()
                => new T();
    }
}