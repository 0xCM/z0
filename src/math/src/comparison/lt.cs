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
        [MethodImpl(Inline), Lt]
        public static bool lt(sbyte a, sbyte b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(byte a, byte b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(short a, short b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(ushort a, ushort b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(int a, int b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(uint a, uint b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(long a, long b)
            => a < b;

        [MethodImpl(Inline), Lt]
        public static bool lt(ulong a, ulong b)
            => a < b;        
    }
}