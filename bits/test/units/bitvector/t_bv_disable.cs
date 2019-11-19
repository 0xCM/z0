//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static BitParts;

    public class t_bv_disable : BitVectorTest<t_bv_disable>
    {        

        public void bv_disable_after_16()
        {
            var src = BitVector16.Ones;
            var dst = src.Replicate();
            dst.DisableAfter(2);
            Claim.eq((ushort)0b111, dst);
        }

        public void bv_disable_g16()
        {
            bv_disable_check<ushort>(16);
            bv_disable_ng_check<N16,ushort>();
        }

        public void bv_disable_g32()
        {
            bv_disable_check<uint>(32);
            bv_disable_ng_check<N32,uint>();
        }

        public void bv_disable_g64()
        {
            bv_disable_check<ulong>(64);
            bv_disable_ng_check<N64,ulong>();
        }

        public void bv_disable_g213()
        {
            var len = 213;
            bv_disable_check<byte>(len);
            bv_disable_check<ushort>(len);
            bv_disable_check<uint>(len);
            bv_disable_check<ulong>(len);

        }

        public void bv_disable_ng213()
        {
            var n213 = nat(n2,n1,n3);
            bv_disable_ng_check(n213, (byte)0);
            bv_disable_ng_check(n213, (ushort)0);
            bv_disable_ng_check(n213, (uint)0);
            bv_disable_ng_check(n213, (ulong)0);
        }

        void bv_disable_ng707x64u()
        {
            var n707 = nat(n7,n0,n7);
            Claim.eq(707,(int)n707.NatValue);
            bv_disable_ng_check(n707, (ulong)0);

        }

        void bv_disable_check<T>(BitSize n)
            where T : unmanaged
        {
            for(var k=0; k<SampleSize; k++)
            {
                var bv = Random.BitCells<T>(n);
                var bs = bv.ToBitString();
                Claim.eq(bv.Length, n);
                Claim.eq(bv.Length, bs.Length);
                for(var i=0; i<bv.Length; i+= 2)
                {
                    bv.Disable(i);
                    bs[i] = Bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }

        void bv_disable_ng_check<N,T>(N n = default, T rep = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            for(var k=0; k<SampleSize; k++)
            {
                var bv = Random.BitVector<N,T>();
                var bs = bv.ToBitString();
                Claim.eq(bv.Length, n.NatValue);
                Claim.eq(bv.Length, bs.Length);
                for(var i=0; i<bv.Length; i+= 2)
                {
                    bv.SetBit(i, bit.Off);
                    bs[i] = bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }
    }
}