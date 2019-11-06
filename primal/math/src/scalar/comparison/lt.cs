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
        public static bit lt(sbyte lhs, sbyte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(byte lhs, byte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(short lhs, short rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(ushort lhs, ushort rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(int lhs, int rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(uint lhs, uint rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(long lhs, long rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(ulong lhs, ulong rhs)
            => lhs < rhs;
        
        [MethodImpl(Inline)]
        public static bit lteq(sbyte lhs, sbyte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(byte lhs, byte rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(short lhs, short rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(ushort lhs, ushort rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(int lhs, int rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(uint lhs, uint rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(long lhs, long rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(ulong lhs, ulong rhs)
            => lhs <= rhs; 
    }
}