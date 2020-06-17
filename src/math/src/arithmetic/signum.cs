//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class math
    {
        [MethodImpl(Inline), Op]
        public static SignKind signum(sbyte src)
            => signum((int)src);

        [MethodImpl(Inline), Op]
        public static SignKind signum(byte src)
            => src != 0 ? SignKind.Positive : SignKind.Negative;

        [MethodImpl(Inline), Op]
        public static SignKind signum(short src)
            => signum((int)src);

        [MethodImpl(Inline), Op]
        public static SignKind signum(ushort src)
            => src != 0 ? SignKind.Positive : SignKind.Negative;

        [MethodImpl(Inline), Op]
        public static SignKind signum(int src)
            => (SignKind)((src >> 31) | (int)(negate((uint)src) >> 31)); 

        [MethodImpl(Inline), Op]
        public static SignKind signum(uint src)
            => src != 0 ? SignKind.Positive : SignKind.Negative;

        [MethodImpl(Inline), Op]
        public static SignKind signum(long src)
            => (SignKind)((src >> 63) | (long)(negate((ulong)src) >> 63)); 

        [MethodImpl(Inline), Op]
        public static SignKind signum(ulong src)
            => src != 0 ? SignKind.Positive : SignKind.Negative;
    }
}