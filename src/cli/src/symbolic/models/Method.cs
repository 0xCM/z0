//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using Microsoft.DiaSymReader;

    using static Part;

    partial struct AppSymbolics
    {
        public readonly struct Method
        {
            readonly ISymUnmanagedMethod Source;

            [MethodImpl(Inline)]
            internal Method(ISymUnmanagedMethod src)
                => Source = src;

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Source == null;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Source != null;
            }

            [MethodImpl(Inline)]
            public static bool operator true(Method src)
                => src.IsNonEmpty;

            [MethodImpl(Inline)]
            public static bool operator false(Method src)
                => src.IsEmpty;
        }
    }
}