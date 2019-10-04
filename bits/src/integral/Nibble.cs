//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    public static class Nibble
    {
        public const uint MinValue = 0;

        public const uint MaxValue = 0xF;

        [MethodImpl(Inline)]
        public static uint reduce(uint x)
            =>  Mod<N16>.mod(x);

        [MethodImpl(Inline)]
        public static uint create(Bit x0, Bit x1, Bit x2, Bit x3)
        {
            var data = 0u;
            if(x0) data |= (1 << 0);
            if(x1) data |= (1 << 1);
            if(x2) data |= (1 << 2);
            if(x3) data |= (1 << 3);
            return data;
        }

        [MethodImpl(Inline)]
        public static uint add(uint x, uint y)
        {
            var sum = x + y;
            return (sum >= Modulus) 
                ? (uint)(sum - Modulus)
                : sum;
        }


        [MethodImpl(Inline)]
        public static uint sub(uint x, uint y)
        {
            var diff = (int)x - (int)y;
            return diff < 0 
                ? (uint)(diff + Modulus) 
                : (uint)diff;
        }

        [MethodImpl(Inline)]
        public static uint mul(uint x, uint y)
            =>  reduce(x * y);

        [MethodImpl(Inline)]
        public static ref uint inc(ref uint x)
        {
            if(x != MaxValue)
                x++;
            else
                x = MinValue;
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref uint dec(ref uint x)
        {
            if(x != MinValue)
                x--;
            else
                x = MaxValue;
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref uint enable(ref uint x, int pos)
        {
            if(pos < BitCount)
                x |= (1u << pos);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref uint disable(ref uint x, int pos)
        {
            if(pos < BitCount)
                x &= ~(1u << pos);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static ref uint set(ref uint x, int pos, Bit bit)
        {
            if(bit)
                return ref enable(ref x, pos);
            else
                return ref disable(ref x, pos);
        }

        [MethodImpl(Inline)]
        public static ref uint RotL(ref uint x, int offset)
        {
            x = (x << offset) | (x >> BitCount - offset);
            return ref x;
        }


        [MethodImpl(Inline)]
        public static ref uint rotr(ref uint x, int offset)
        {
            x = (x >> offset) | (x << (BitCount - offset));
            return ref x;
        }


        const uint Modulus = MaxValue + 1;

        const int BitCount = 4;        


    }

}