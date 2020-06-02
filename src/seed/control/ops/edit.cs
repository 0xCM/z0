//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);

        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref byte edit8u<T>(in T src)
            => ref edit<T,byte>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ushort edit16u<T>(in T src)
            => ref edit<T,ushort>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref uint edit32u<T>(in T src)
            => ref edit<T,uint>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref ulong edit64u<T>(in T src)
            => ref edit<T,ulong>(src);
    }
}