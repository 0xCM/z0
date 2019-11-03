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

        public void natural_pops()
        {
            pop_check2<N8,byte>();
            pop_check2<N9,byte>();
            pop_check2<N10,ushort>();
            pop_check2<N11,ushort>();
            pop_check2<N16,byte>();
            pop_check2<N16,ushort>();
            pop_check2<N31,byte>();
            pop_check2<N64,ulong>();
            pop_check2<N128,uint>();
            pop_check2<N256,ulong>();
            pop_check2<N512,ulong>();
            pop_check2<N1024,ulong>();
            pop_check2<N2048,ulong>();
            pop_check2<N4096,ulong>();
            pop_check2<N8192,ulong>();
            pop_check2<N16384,ushort>();            
        }

        void pop_check2<N,T>(N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            
            var len = (int)(Mod8.div((uint)n.value) + (Mod8.mod((uint)n.value) != 0 ? 1 : 0));
            
            var src = Random.Span<byte>(len);

            var bv = BitVector<N,T>.FromBytes(src);
            var pc1 = bv.Pop();

            var bs = BitString.FromScalars(src);
            var pc2 = bs.PopCount();

            Claim.eq(pc1,pc2);
        }

    }
}