//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte min(sbyte lhs, sbyte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static byte min(byte lhs, byte rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static short min(short lhs, short rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ushort min(ushort lhs, ushort rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static int min(int lhs, int rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static uint min(uint lhs, uint rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static long min(long lhs, long rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ulong min(ulong lhs, ulong rhs)
            => lhs < rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ref sbyte min(ref sbyte lhs, sbyte rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte min(ref byte lhs, byte rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short min(ref short lhs, short rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort min(ref ushort lhs, ushort rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int min(ref int lhs, int rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint min(ref uint lhs, uint rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long min(ref long lhs, long rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong min(ref ulong lhs, ulong rhs)
        {
            lhs = lhs < rhs ? lhs : rhs;
            return ref lhs;
        }
    }
}