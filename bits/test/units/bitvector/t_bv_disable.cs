//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_disable : BitVectorTest<t_bv_disable>
    {        
        public void bv_disable_after_16()
        {
            var src = BitVector16.Ones;
            var dst = src.Replicate();
            dst = BitVector.zerohi(dst,2);
            Claim.eq((ushort)0b111, dst);
        }

        public void gbv_disable_16()
        {
            bv_disable_check<ushort>(16);
            nbv_disable_check<N16,ushort>();
        }

        public void gbv_disable_32()
        {
            bv_disable_check<uint>(32);
            nbv_disable_check<N32,uint>();
        }

        public void gbv_disable_64()
        {
            bv_disable_check<ulong>(64);
            nbv_disable_check<N64,ulong>();
        }

        public void gbv_disable_213()
        {
            var len = 213;
            bv_disable_check<byte>(len);
            bv_disable_check<ushort>(len);
            bv_disable_check<uint>(len);
            bv_disable_check<ulong>(len);

        }

        public void nbv_disable_213()
        {
            var n213 = nat(n2,n1,n3);
            nbv_disable_check(n213, (byte)0);
            nbv_disable_check(n213, (ushort)0);
            nbv_disable_check(n213, (uint)0);
            nbv_disable_check(n213, (ulong)0);
        }

        void nbv_disable_707x64u()
        {
            var n707 = nat(n7,n0,n7);
            Claim.eq(707,(int)n707.NatValue);
            nbv_disable_check(n707, (ulong)0);
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
                    bv[i] = bit.Off;
                    bs[i] = bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }

        void nbv_disable_check<N,T>(N n = default, T rep = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            for(var k=0; k<SampleSize; k++)
            {
                var bv = Random.BitCells<N,T>();
                var bs = bv.ToBitString();
                Claim.eq(bv.Length, n.NatValue);
                Claim.eq(bv.Length, bs.Length);
                for(var i=0; i<bv.Length; i+= 2)
                {
                    bv[i] = bit.Off;
                    bs[i] = bit.Off;
                }

                Claim.eq(bv.ToBitString(),bs);
            }
        }
    }
}