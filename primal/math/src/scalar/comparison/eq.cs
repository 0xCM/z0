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
        public static bit eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bit eq(ulong lhs, ulong rhs)
            => lhs == rhs;
  
        [MethodImpl(Inline)]
        public static bit neq(sbyte lhs, sbyte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(byte lhs, byte rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(short lhs, short rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(ushort lhs, ushort rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(int lhs, int rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(uint lhs, uint rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(long lhs, long rhs)
            => lhs != rhs;

        [MethodImpl(Inline)]
        public static bit neq(ulong lhs, ulong rhs)
            => lhs != rhs;

 
    }
}