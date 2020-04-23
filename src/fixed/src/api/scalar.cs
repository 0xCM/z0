//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class Fixed
    {
        [MethodImpl(Inline), Op]
        public static byte scalar(Fixed8 src)
            =>  (byte)src;

        [MethodImpl(Inline), Op]
        public static ushort scalar(Fixed16 src)
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static uint scalar(Fixed32 src)
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static ulong scalar(Fixed64 src)
            => (ulong)src;
    }
}