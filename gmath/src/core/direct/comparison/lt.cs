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
        public static bit lt(sbyte a, sbyte b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(byte a, byte b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(short a, short b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(ushort a, ushort b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(int a, int b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(uint a, uint b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(long a, long b)
            => a < b;

        [MethodImpl(Inline), Op]
        public static bit lt(ulong a, ulong b)
            => a < b;
        
        [MethodImpl(Inline), Op]
        public static bit lteq(sbyte a, sbyte b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(byte a, byte b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(short a, short b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(ushort a, ushort b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(int a, int b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(uint a, uint b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(long a, long b)
            => a <= b;

        [MethodImpl(Inline), Op]
        public static bit lteq(ulong a, ulong b)
            => a <= b; 
    }
}