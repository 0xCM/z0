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
        public static bit nonzero(sbyte src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(byte src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(short src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(ushort src)
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
        public static bit nonzero(ulong src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonzero(float src)
            => src != 0;
            
        [MethodImpl(Inline), Op]
        public static bit nonzero(double src)
            => src != 0;
    }
}