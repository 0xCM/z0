//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static bool gt(sbyte a, sbyte b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(byte a, byte b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(short a, short b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(ushort a, ushort b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(int a, int b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(uint a, uint b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(long a, long b)
            => a > b;

        [MethodImpl(Inline)]
        public static bool gt(ulong a, ulong b)
            => a > b;
 
         [MethodImpl(Inline)]
        public static bool gteq(sbyte a, sbyte b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(byte a, byte b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(short a, short b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(ushort a, ushort b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(int a, int b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(uint a, uint b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(long a, long b)
            => a >= b;

        [MethodImpl(Inline)]
        public static bool gteq(ulong a, ulong b)
            => a >= b;
    }
}