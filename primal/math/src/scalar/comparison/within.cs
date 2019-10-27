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
        public static bool within(byte lhs, byte rhs, byte epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(sbyte lhs, sbyte rhs, sbyte epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(short lhs, short rhs, short epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(ushort lhs, ushort rhs, ushort epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(int lhs, int rhs, int epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(uint lhs, uint rhs, uint epsilon)
                => lhs > rhs ? lhs - rhs <= epsilon 
                : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(long lhs, long rhs, long epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(ulong lhs, ulong rhs, ulong epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;


    }

}