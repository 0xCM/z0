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
        public void bvdot_4u()
        {
            dot4_check();            
        }

        public void bvdot_8u()
        {
            dot8_check();            
        }

        public void bvdot_16u()
        {
            dot16_check();            
        }

        public void bv_dot_32u()
        {
            dot32_check();            
        }

        public void bv_dot_64u()
        {
            dot64_check();  

            for(var i=0; i< SampleSize; i++)          
            {
                var x32 = Random.BitVector(n32);
                var y32 = Random.BitVector(n32);
                var dot32 = bitvector.dot(x32,y32);
                var x64 = x32.ToBitVector64();
                var y64 = y32.ToBitVector64();
                var dot64 = bitvector.dot(x64,y64);
                Claim.eq(dot32,dot64);
            }
        }

        public void dotg()
        {
            dotg_check<uint>(10);
            dotg_check<uint>(20);
            dotg_check<ulong>(63);
            dotg_check<ulong>(64);
            dotg_check<byte>(87);
            dotg_check<ushort>(128);
            dotg_check<ushort>(25);
            dotg_check<ulong>(256);
            dotg_check<uint>(2048);
        }

        public void dotng()
        {
            dotng_check(n10,0u);
            dotng_check(n20,0u);
            dotng_check(n63,0ul);
            dotng_check(n64,0ul);
            dotng_check(n87,(byte)0);
            dotng_check(n128,(ushort)0);
            dotng_check(n25,(ushort)0);
            dotng_check(n256,0ul);
            dotng_check(n2048,0u);
        }


        void Dot4Table()
        {
            var result = sbuild();
            for(byte i=0; i< 0xF; i++)
            {
                var x = BitVector4.FromScalar(i);
                for(byte j = 0; j<0xF; j++)
                {
                    var y = BitVector4.FromScalar(j);
                    var a = x & y;
                    var and = $"AND = {a.Format()}";
                    var popMod2 = $"AND > POP % 2 = {a.Pop() % 2}";
                    result.AppendLine($"{x.Format()} * {y.Format()} = {x % y} | {and} | {popMod2}");
                }
            }
            Trace(result.ToString());
        }

        void dot4_check(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var x = Random.BitVector(n4);
                var y = Random.BitVector(n4);
                var a = x % y;
                var b = ModProd(x,y);
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
                var b = ModProd(x,y);
                Claim.yea(a == b);            

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
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
                var b = ModProd(x,y);
                Claim.yea(a == b);   

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
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
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
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
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);

                var zx = x.ToGeneric();
                var zy = y.ToGeneric();
                var c = zx % zy;
                Claim.yea(a == c);
            
            }
        }

        void dotg_check<T>(int bitcount, T rep = default)
            where T : unmanaged
        {
            TypeCaseStart<T>();

            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitVector<T>(bitcount);
                var y = Random.BitVector<T>(bitcount);
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);
            
            }

            TypeCaseEnd<T>();
        }

        void dotng_check<N,T>(N bitcount = default, T rep = default)
            where T : unmanaged
            where N : ITypeNat, new()
        {
            NatCaseStart<N,T>();
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitVector<N,T>();
                var y = Random.BitVector<N,T>();
                var a = x % y;
                var b = ModProd(x,y);
                Claim.yea(a == b);            
            }

            NatCaseStart<N,T>();
        }
 
    }

}