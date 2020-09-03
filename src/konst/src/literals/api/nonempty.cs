//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static bool nonempty(in BinaryLiteral src)
            => !text.blank(src.Name) && !sys.blank(src.Text) && src.Data != null;

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool nonempty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => !text.blank(src.Name) && !text.blank(src.Text) && !src.Data.Equals(default);
    }
}