//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell8 cell(ReadOnlySpan<byte> src, W8 n)
            => core.first(src);

        [MethodImpl(Inline), Op]
        public static Cell16 cell(ReadOnlySpan<byte> src, W16 w)
            => core.first(recover<byte,ushort>(slice(src,2)));

        [MethodImpl(Inline), Op]
        public static Cell32 cell(ReadOnlySpan<byte> src, W32 w)
            => core.first(recover<byte,uint>(slice(src,4)));

        [MethodImpl(Inline), Op]
        public static Cell64 cell(ReadOnlySpan<byte> src, W64 w)
            => core.first(recover<byte,ulong>(slice(src,8)));

        [MethodImpl(Inline), Op]
        public static Cell128 cell(ReadOnlySpan<byte> src, W128 w)
            => core.first(recover<byte,Vector128<ulong>>(slice(src,16)));

        [MethodImpl(Inline), Op]
        public static Cell128 cell(W128 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,Vector128<ulong>>(slice(src,16)));

        [MethodImpl(Inline), Op]
        public static Cell256 cell(ReadOnlySpan<byte> src, W256 w)
            => core.first(recover<byte,Vector256<ulong>>(slice(src,32)));

        [MethodImpl(Inline), Op]
        public static Cell256 cell(W256 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,Vector256<ulong>>(slice(src,32)));

        [MethodImpl(Inline), Op]
        public static Cell512 cell(ReadOnlySpan<byte> src, W512 w)
            => core.first(recover<byte,Vector512<ulong>>(slice(src,32)));

        [MethodImpl(Inline)]
        public static F fix<T,F>(T src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => Unsafe.As<T,F>(ref src);

        [MethodImpl(Inline)]
        public static T unfix<F,T>(F src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => Unsafe.As<F,T>(ref src);
    }
}