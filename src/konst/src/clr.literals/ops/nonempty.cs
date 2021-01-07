//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op]
        public static bool nonempty(in BinaryLiteral src)
            => text.nonempty(src.Name) && text.nonempty(src.Text) && src.Data != null;

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool nonempty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => text.nonempty(src.Name) && text.nonempty(src.Text) && !src.Data.Equals(default);
    }
}