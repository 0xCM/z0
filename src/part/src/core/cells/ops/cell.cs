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
        public static Cell8 cell8(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 cell(byte a0, byte a1)
            => core.uint16((ushort)a0 | ((ushort)a1 << 8));

        [MethodImpl(Inline), Op]
        public static Cell32 cell(byte a0, byte a1, byte a2)
            => (uint)a0 | ((uint)a1 << 8) | ((uint)a2 << 16);

        [MethodImpl(Inline), Op]
        public static Cell32 cell(byte a0, byte a1, byte a2, byte a3)
            => (uint)a0 | ((uint)a1 << 8) | ((uint)a2 << 16) | ((uint)a3 << 24);

        [MethodImpl(Inline), Op]
        public static Cell8 cell(W8 w, ReadOnlySpan<byte> src)
            => core.first(src);

        [MethodImpl(Inline), Op]
        public static Cell16 cell(W16 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,ushort>(slice(src,2)));

        [MethodImpl(Inline), Op]
        public static Cell32 cell(W32 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,uint>(slice(src,4)));

        [MethodImpl(Inline), Op]
        public static Cell64 cell(W64 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,ulong>(slice(src,8)));

        [MethodImpl(Inline), Op]
        public static Cell128 cell(W128 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,Vector128<ulong>>(slice(src,16)));

        [MethodImpl(Inline), Op]
        public static Cell256 cell(W256 w, ReadOnlySpan<byte> src)
            => core.first(recover<byte,Vector256<ulong>>(slice(src,32)));

        [MethodImpl(Inline), Op]
        public static Cell512 cell(W512 w, ReadOnlySpan<byte> src)
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