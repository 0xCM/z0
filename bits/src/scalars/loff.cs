//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    partial class Bits
    {

        [MethodImpl(Inline)]
        public static byte loff(byte src)
            => (byte)(src & (src - 1));

        [MethodImpl(Inline)]
        public static ushort loff(ushort src)
            => (ushort)(src & (src - 1));

        [MethodImpl(Inline)]
        public static uint loff(uint src)
            => (src & (src - 1));

        [MethodImpl(Inline)]
        public static ulong loff(ulong src)
            => (src & (src - 1));
    }
}