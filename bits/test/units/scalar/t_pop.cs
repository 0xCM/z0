//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    
    using static zfunc;
    
    public class t_pop : ScalarBitTest<t_pop>
    {
        public void pop1()
        {
            Span<byte> bits = stackalloc byte[16];
            var src = (ushort)0b11001111;
            BitParts.unpack16x1(src,bits);
            var bitsPC = bits.PopCount();
            Claim.eq(6,bitsPC);

            var bytes = Unmanaged.ByteSpan(ref src);
            Claim.eq(2, bytes.Length);
            
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);
        }


        public void pop_64u_check()
        {
            Span<byte> x = stackalloc byte[64];
    
            for(var i=0; i< SampleSize; i++)
            {
                var y = BitConverter.GetBytes(Random.Next<ulong>()).ToSpan();
                y.Unpack(x);
                Claim.eq(x.PopCount(), y.PopCount());
            }
        }

        public void pop6()
        {
            var xBytes = Random.Span<byte>(5);
            var x = Bytes.read<ulong>(xBytes);
            var xPC = Bits.pop(x);
            var xBits = xBytes.Unpack();
            var xBitsPC = xBits.PopCount();
            var xBytesPC = xBytes.PopCount();

            Claim.eq(xPC, xBitsPC);
            Claim.eq(xPC, xBytesPC);
        }

        public void pop7()
        {
            var xBytes = Random.Span<byte>(Pow2.T10 - 3);
            var xBytesPC = xBytes.PopCount();
            var xBitsPC = xBytes.Unpack().PopCount();
            Claim.eq(xBitsPC, xBytesPC);
        }

        void PopCounts<N,T>()
            where T : unmanaged
            where N : INatPow2, new()
        {
            var src = Random.Span<T>((int)new N().value);

            var pc1 = 0ul;
            for(var i = 0; i<src.Length; i++)
            {
                var bv = BitVector<N,T>.FromArray(src[i]);
                pc1 += bv.Pop();
            }

            for(var i = 0; i<src.Length; i++)
            {
                var bs = BitString.FromScalar(in src[i]);
            }
        }
    }
}