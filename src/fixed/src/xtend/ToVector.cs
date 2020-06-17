//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Vector128<T> ToVector<T>(this in Fixed128 src)
            where T : unmanaged
                => Fixed.vector<T>(src);

        [MethodImpl(Inline)]
        public static Vector256<T> ToVector<T>(this in Fixed256 src)
            where T : unmanaged
                => Fixed.vector<T>(src);

        [MethodImpl(Inline)]
        public static Vector512<T> ToVector<T>(this in Fixed512 src)
            where T : unmanaged
                => Unsafe.As<Fixed512,Vector512<T>>(ref Unsafe.AsRef(in src));
    }
}