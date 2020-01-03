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

        [MethodImpl(Inline)]
        public static sbyte not(sbyte src)
            => (sbyte)(~ src);

        [MethodImpl(Inline)]
        public static byte not(byte src)
            => (byte)(~ src);

        [MethodImpl(Inline)]
        public static short not(short src)
            => (short)(~ src);

        [MethodImpl(Inline)]
        public static ushort not(ushort src)
            => (ushort)(~ src);

        [MethodImpl(Inline)]
        public static int not(int src)
            => ~ src;

        [MethodImpl(Inline)]
        public static uint not(uint src)
            => ~ src;

        [MethodImpl(Inline)]
        public static long not(long src)
            => ~ src;

        [MethodImpl(Inline)]
        public static ulong not(ulong src)
            => ~ src;

        [MethodImpl(Inline)]
        public static ref sbyte not(ref sbyte src)
        {
            src = (sbyte) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte not(ref byte src)
        {
            src = (byte) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short not(ref short src)
        {
            src = (short) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort not(ref ushort src)
        {
            src = (ushort) ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int not(ref int src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint not(ref uint src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long not(ref long src)
        {
            src = ~src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong not(ref ulong src)
        {
            src = ~src;
            return ref src;
        }
 
 
    }
}