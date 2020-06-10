//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly byte view8u<T>(in T src)
            => ref view<T,byte>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly ushort view16u<T>(in T src)
            => ref view<T,ushort>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly uint view32u<T>(in T src)
            => ref view<T,uint>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly ulong view64u<T>(in T src)
            => ref view<T,ulong>(src);
    }
}