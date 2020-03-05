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
        public static sbyte not(sbyte src)
            => (sbyte)(~ src);

        [MethodImpl(Inline), Op]
        public static byte not(byte src)
            => (byte)(~ src);

        [MethodImpl(Inline), Op]
        public static short not(short src)
            => (short)(~ src);

        [MethodImpl(Inline), Op]
        public static ushort not(ushort src)
            => (ushort)(~ src);

        [MethodImpl(Inline), Op]
        public static int not(int src)
            => ~ src;

        [MethodImpl(Inline), Op]
        public static uint not(uint src)
            => ~ src;

        [MethodImpl(Inline), Op]
        public static long not(long src)
            => ~ src;

        [MethodImpl(Inline), Op]
        public static ulong not(ulong src)
            => ~ src;

 
    }
}