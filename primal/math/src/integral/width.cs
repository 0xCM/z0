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
        public static byte width(byte lhs, byte rhs)
            =>  (byte)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static ushort width(sbyte lhs, sbyte rhs)
            => (ushort)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static uint width(short lhs, short rhs)
            =>  (uint)abs((int)rhs - (int)lhs);

        [MethodImpl(Inline)]
        public static ushort width(ushort lhs, ushort rhs)
            => (ushort)(lhs > rhs ? lhs - rhs : rhs - lhs);

        [MethodImpl(Inline)]
        public static ulong width(int lhs, int rhs)
            => (ulong)abs((long)rhs - (long)lhs);

        [MethodImpl(Inline)]
        public static ulong width(long lhs, long rhs)
            => (ulong)abs(rhs - lhs);

        [MethodImpl(Inline)]
        public static uint width(uint lhs, uint rhs)
            => lhs > rhs ? lhs - rhs : rhs - lhs;

        [MethodImpl(Inline)]
        public static ulong width(ulong lhs, ulong rhs)
            => lhs > rhs ? lhs - rhs : rhs - lhs;
 
    }
}