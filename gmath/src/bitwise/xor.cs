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
        public static sbyte xor(sbyte a, sbyte b)
            => (sbyte)(a ^ b);

        [MethodImpl(Inline)]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline)]
        public static short xor(short a, short b)
            => (short)(a ^ b);

        [MethodImpl(Inline)]
        public static ushort xor(ushort a, ushort b)
            => (ushort)(a ^ b);

        [MethodImpl(Inline)]
        public static int xor(int a, int b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static uint xor(uint a, uint b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static long xor(long a, long b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static ulong xor(ulong a, ulong b)
            => a ^ b;

        [MethodImpl(Inline)]
        public static ref sbyte xor(ref sbyte a, sbyte b)
        {
            a = (sbyte)(a ^ b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte xor(ref byte a, byte b)
        {
            a = (byte)(a ^ b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short xor(ref short a, short b)
        {
            a = (short)(a ^ b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort xor(ref ushort a, ushort b)
        {
            a = (ushort)(a ^ b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int xor(ref int a, int b)
        {
            a = a ^ b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint xor(ref uint a, uint b)
        {
            a = a ^ b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long xor(ref long a, long b)
        {
            a = a ^ b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong xor(ref ulong a, ulong b)
        {
            a = a ^ b;
            return ref a;
        }


        [MethodImpl(Inline)]
        public static ref sbyte xor(in sbyte a, in sbyte b, ref sbyte dst)
        {
            dst = (sbyte)(a ^ b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte xor(in byte a, in byte b, ref byte dst)
        {
            dst = (byte)(a ^ b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref short xor(in short a, in short b, ref short dst)
        {
            dst = (short)(a ^ b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ushort xor(in ushort a, in ushort b, ref ushort dst)
        {
            dst = (ushort)(a ^ b);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref int xor(in int a, in int b, ref int dst)
        {
            dst = a ^ b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref uint xor(in uint a, in uint b, ref uint dst)
        {
            dst = a ^ b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref long xor(in long a, in long b, ref long dst)
        {
            dst = a ^ b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref ulong xor(in ulong a, in ulong b, ref ulong dst)
        {
            dst = a ^ b;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref float xor(in float a, in float b, ref float dst)
        {
            dst = BitConverter.Int32BitsToSingle(a.ToBits() ^ b.ToBits());
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref double xor(in double a, in double b, ref double dst)
        {
            dst = BitConverter.Int64BitsToDouble(a.ToBits() ^ b.ToBits());
            return ref dst;
        }        
    }
}