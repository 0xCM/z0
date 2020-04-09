//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Scalar
    {
        [MethodImpl(Inline), Op]
        public static bit nonz(sbyte src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(byte src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(short src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(ushort src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(int src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(uint src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(long src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(ulong src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(float src)
            => src != 0;
            
        [MethodImpl(Inline), Op]
        public static bit nonz(double src)
            => src != 0;
    }            

}