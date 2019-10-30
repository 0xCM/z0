//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static BitRef;


    public class t_bvdot : BitVectorTest<t_bvdot>
    {
        public void dot_4u_check()
        {
            dot4_check();            
        }

        public void dot_8u_check()
        {
            dot8_check();            
        }

        public void dot_16u_check()
        {
            dot16_check();            
        }

        public void dot_32u_check()
        {
            dot32_check();            
        }

        public void dot_64u_check()
        {
            dot64_check();  

            for(var i=0; i< SampleSize; i++)          
            {
                var x32 = Random.BitVector(n32);
                var y32 = Random.BitVector(n32);
                var dot32 = BitVector.dot(x32,y32);
                var x64 = x32.ToBitVector64();
                var y64 = y32.ToBitVector64();
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
            dot_natural_check<N8,byte>();
            dot_natural_check<N16,ushort>();
            dot_natural_check<N32,uint>();
            dot_natural_check<N64,ulong>();


            dot_natural_check<N64,uint>();

            dot_natural_check<N128,ushort>();
            dot_natural_check<N128,uint>();
            dot_natural_check<N256,uint>();
            dot_natural_check<N256,ulong>();
            dot_natural_check<N2048,uint>();

            dot_natural_check<N10,uint>();
            dot_natural_check<N20,uint>();


            dot_natural_check(n63,0ul);
            dot_natural_check(n87,(byte)0);
            dot_natural_check(n25,(ushort)0);

        }

        public void dot_bitcells_check()
        {
            dot_bitcells_check<uint>(10);
            dot_bitcells_check<uint>(20);
            dot_bitcells_check<ulong>(63);
            dot_bitcells_check<ulong>(64);
            dot_bitcells_check<byte>(87);
            dot_bitcells_check<ushort>(128);
            dot_bitcells_check<ushort>(25);
            dot_bitcells_check<ulong>(256);
            dot_bitcells_check<uint>(2048);
        }

        void dot4_check()
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

        void dot8_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);            

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void dot16_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);   

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                var c = zx % zy;
                Claim.yea(a == c);

            }
        }

        void dot32_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                var a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);
            
                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                var c = zx % zy;
                Claim.yea(a == c);
            }
        }

        void dot64_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                bit a = x % y;
                var b = modprod(x,y);
                Claim.yea(a == b);

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                bit c = zx % zy;
                Claim.yea(a == c);
            
            }
        }

        void dot_bitcells_check<T>(int bitcount)
            where T : unmanaged
        {
            TypeCaseStart<T>();

            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitCells<T>(bitcount);
                var y = Random.BitCells<T>(bitcount);
                var a = x % y;
                var b = modprod(x,y);
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

        void dot_natural_check<N,T>(N bitcount = default, T rep = default)
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
                Claim.yea(a == b);            
            }
            NatCaseStart<N,T>();
        }
 
    }

}