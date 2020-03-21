//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    
    
    partial class math
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
        public static bit nonz(int src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(uint src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(long src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bit nonz(ulong src)
            => src != 0;
    }
}