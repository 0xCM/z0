//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static BitVector;

    public class t_bv_dot : BitVectorTest<t_bv_dot>
    {
        public void vdot_p4()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n4);
                var y = Random.BitVector(n4);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);            
            }
        }


        public void vdot_p8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);            

                var zx = x.ToCells();
                var zy = y.ToCells();
                var c = zx % zy;
                Claim.yea(a == c);
            }            
        }

        public void vdot_p16()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);   

                var zx = x.ToCells();
                var zy = y.ToCells();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        public void vdot_p32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);   

                var zx = x.ToNatural();
                var zy = y.ToNatural();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        public void vdot_p64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                bit a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);

                var zx = x.ToCells();
                var zy = y.ToCells();
                bit c = zx % zy;
                Claim.yea(a == c);            
            }

            for(var i=0; i< SampleSize; i++)          
            {
                var x32 = Random.BitVector(n32);
                var y32 = Random.BitVector(n32);
                var dot32 = BitVector.dot(x32,y32);
                var x64 = x32.Expand(n64);
                var y64 = y32.Expand(n64);
                var dot64 = BitVector.dot(x64,y64);
                Claim.eq(dot32,dot64);
            }
        }

        public void dot_generic_check()
        {
            dot_generic_check<byte>();
            dot_generic_check<ushort>();
            dot_generic_check<uint>();
            dot_generic_check<ulong>();
        }

        public void dot_nat_check()
        {
            nbv_dot_check<N8,byte>();
            nbv_dot_check<N16,ushort>();
            nbv_dot_check<N32,uint>();
            nbv_dot_check<N64,ulong>();
            nbv_dot_check<N64,uint>();

            nbv_dot_check<N10,uint>();
            nbv_dot_check<N20,uint>();
            nbv_dot_check(n25,(ushort)0);
            nbv_dot_check(n27, ushort.MinValue);

            nbv_dot_check(n63,0ul);
            nbv_dot_check(n87,(byte)0);

            nbv_dot_check<N128,ushort>();
            nbv_dot_check<N128,uint>();

            var n217 = natseq(n2,n1,n7);

            nbv_dot_check(n217, uint.MinValue);
            nbv_dot_check(n217, ushort.MinValue);
            nbv_dot_check(n217, ulong.MinValue);
            nbv_dot_check<N256,uint>();
            nbv_dot_check<N256,ulong>();
        }

        public void dot_bitcells_check()
        {
            bcdot_check<uint>(10);
            bcdot_check<uint>(20);
            bcdot_check<ulong>(63);
            bcdot_check<ulong>(64);
            bcdot_check<byte>(87);
            bcdot_check<ushort>(128);
            bcdot_check<ushort>(25);
            bcdot_check<ulong>(256);
            bcdot_check<uint>(2048);
        }

        void bcdot_check<T>(int bitcount)
            where T : unmanaged
        {
            TypeCaseStart<T>();

            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitCells<T>(bitcount);
                var y = Random.BitCells<T>(bitcount);
                var a = x % y;
                var b = BitCells.modprod(x,y);
                Claim.yea(a == b);            
            }

            TypeCaseEnd<T>();
        }

        void dot_generic_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitVector<T>();
                var y = Random.BitVector<T>();
                var actual = BitVector.dot(x,y);
                var expect = modprod(x,y);
                Claim.yea(actual == expect);            
            }
            TypeCaseEnd<T>();
        }

        void nbv_dot_check<N,T>(N bitcount = default, T rep = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            NatCaseStart<N,T>();
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = Random.BitVector<N,T>();
                bit a = x % y;
                var b = modprod(x,y);
                if(a != b)
                    Trace($"{bitcount}x{moniker<T>()} is a problem");
                Claim.yea(a == b);            
            }
            NatCaseStart<N,T>();
        }

    }
}