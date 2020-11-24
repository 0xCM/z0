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

    partial struct SyntaxModels
    {
        [Op]
        public static string format(Fence src)
            => string.Format(FencePattern, src.Left, src.Right);

        [Op, Closures(UnsignedInts)]
        public static string format<T>(Fence<T> src)
            where T : unmanaged
                => string.Format(FencePattern, src.Left, src.Right);

        [Op]
        public static string format(in Fence src)
            => format(FencePattern, src.Left, src.Right);

        [MethodImpl(Inline)]
        static string format<A,B>(string pattern, A a, B b)
            => string.Format(pattern, a, b);
    }
}