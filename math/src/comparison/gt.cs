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
        [MethodImpl(Inline), Gt]
        public static bit gt(sbyte a, sbyte b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(byte a, byte b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(short a, short b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(ushort a, ushort b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(int a, int b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(uint a, uint b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(long a, long b)
            => a > b;

        [MethodImpl(Inline), Gt]
        public static bit gt(ulong a, ulong b)
            => a > b;
 
    }
}