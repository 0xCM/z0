//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static BitMasks.Literals;

    partial class BitMasks
    {
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcentral(N128 w, W8 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central8x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(N128 w, W16 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central16x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(N128 w, W32 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central32x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(N128 w, W64 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central64x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcentral(N128 w, W8 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central8x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(N128 w, W16 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central16x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(N128 w, W32 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central32x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(N128 w, W64 t, N8 f, N4 d)
            => cpu.vbroadcast(w,  Central64x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(N128 w, W16 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central16x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(N128 w, W32 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central32x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(N128 w, W64 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central64x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(N128 w, W32 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central32x32x16);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(N128 w, W64 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central64x32x16);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(N128 w, W64 t, N64 f, N32 d)
            => cpu.vbroadcast(w, Central64x64x32);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcentral(N256 w, W8 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central8x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(N256 w, W16 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central16x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(N256 w, W32 t, N4 f, N2 d)
            => gcpu.vbroadcast<uint>(w,  Central32x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(N256 w, W64 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central64x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcentral(N256 w, W8 t, N4 f, N4 d)
            => cpu.vbroadcast(w,  Central8x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(N256 w, W16 t, N4 f, N4 d)
            => cpu.vbroadcast(w,  Central16x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(N256 w, W32 t, N4 f, N4 d)
            => gcpu.vbroadcast<uint>(w,  Central32x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(N256 w, W64 t, N4 f, N4 d)
            => cpu.vbroadcast(w, Central64x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(N256 w, W16 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central16x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(N256 w, W32 t, N16 f, N8 d)
            => gcpu.vbroadcast<uint>(w,  Central32x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(N256 w, W64 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central64x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(N256 w, W32 t, N32 f, N16 d)
            => gcpu.vbroadcast<uint>(w,  Central32x32x16);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(N256 w, W64 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central64x32x16);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(N256 w, W64 t, N64 f, N32 d)
            => cpu.vbroadcast(w, Central64x64x32);
    }
}