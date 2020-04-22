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
        [MethodImpl(Inline)]
        public static byte unfix(Fixed8 src)
            =>  (byte)src;

        [MethodImpl(Inline)]
        public static ushort unfix(Fixed16 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static uint unfix(Fixed32 src)
            => (uint)src;

        [MethodImpl(Inline)]
        public static ulong unfix(Fixed64 src)
            => (ulong)src;
    }
}