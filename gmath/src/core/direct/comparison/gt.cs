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
        public static bit gt(sbyte a, sbyte b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(byte a, byte b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(short a, short b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(ushort a, ushort b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(int a, int b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(uint a, uint b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(long a, long b)
            => a > b;

        [MethodImpl(Inline), Op]
        public static bit gt(ulong a, ulong b)
            => a > b;
 
         [MethodImpl(Inline), Op]
        public static bit gteq(sbyte a, sbyte b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(byte a, byte b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(short a, short b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(ushort a, ushort b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(int a, int b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(uint a, uint b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(long a, long b)
            => a >= b;

        [MethodImpl(Inline), Op]
        public static bit gteq(ulong a, ulong b)
            => a >= b;
    }
}