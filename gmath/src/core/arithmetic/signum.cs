//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    
    using static zfunc;

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static Sign signum(sbyte src)
            => signum((int)src);

        [MethodImpl(Inline), Op]
        public static Sign signum(byte src)
            => src != 0 ? Sign.Pos : Sign.Neg;

        [MethodImpl(Inline), Op]
        public static Sign signum(short src)
            => signum((int)src);

        [MethodImpl(Inline), Op]
        public static Sign signum(ushort src)
            => src != 0 ? Sign.Pos : Sign.Neg;

        [MethodImpl(Inline), Op]
        public static Sign signum(int src)
            => (Sign)((src >> 31) | (int)(negate((uint)src) >> 31)); 

        [MethodImpl(Inline), Op]
        public static Sign signum(uint src)
            => src != 0 ? Sign.Pos : Sign.Neg;

        [MethodImpl(Inline), Op]
        public static Sign signum(long src)
            => (Sign)((src >> 63) | (long)(negate((ulong)src) >> 63)); 

        [MethodImpl(Inline), Op]
        public static Sign signum(ulong src)
            => src != 0 ? Sign.Pos : Sign.Neg;


    }

}