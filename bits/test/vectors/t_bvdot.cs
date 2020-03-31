//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static BitVector;

    /// <summary>
    /// Verifies the correct function of the natural bitvector dot product operator
    /// </summary>
    public class t_bvdot : t_bitvectors<t_bvdot>
    {
        public void bvdot_n64x128x64()
            => bvdot_check_n128<N63,ulong>();

        public void bvdot_natcheck()
        {
            bvdot_natcheck(z8);
            bvdot_natcheck(z16);
            bvdot_natcheck(z32);
            bvdot_natcheck(z64);
        }

        public void bvdot_gcheck()
        {
            bvdot_gcheck<byte>();
            bvdot_gcheck<ushort>();
            bvdot_gcheck<uint>();
            bvdot_gcheck<ulong>();
        }

        void bvdot_natcheck(byte t)
        {   
            bvdot_natcheck<N2,byte>();
            bvdot_natcheck<N3,byte>();
            bvdot_natcheck<N4,byte>();
            bvdot_natcheck<N5,byte>();
            bvdot_natcheck<N6,byte>();
            bvdot_natcheck<N7,byte>();
            bvdot_natcheck<N8,byte>();
       }

        void bvdot_natcheck(ushort t)
        {   
            bvdot_natcheck<N2,ushort>();
            bvdot_natcheck<N3,ushort>();
            bvdot_natcheck<N4,ushort>();
            bvdot_natcheck<N5,ushort>();
            bvdot_natcheck<N6,ushort>();
            bvdot_natcheck<N7,ushort>();
            bvdot_natcheck<N8,ushort>();
            bvdot_natcheck<N9,ushort>();
            bvdot_natcheck<N10,ushort>();
            bvdot_natcheck<N11,ushort>();
            bvdot_natcheck<N12,ushort>();
            bvdot_natcheck<N13,ushort>();
            bvdot_natcheck<N14,ushort>();
            bvdot_natcheck<N15,ushort>();
            bvdot_natcheck<N16,ushort>();
        }

        void bvdot_natcheck(uint t)        
        {
            bvdot_natcheck<N2,uint>();
            bvdot_natcheck<N3,uint>();
            bvdot_natcheck<N4,uint>();
            bvdot_natcheck<N5,uint>();
            bvdot_natcheck<N6,uint>();
            bvdot_natcheck<N7,uint>();
            bvdot_natcheck<N8,uint>();
            bvdot_natcheck<N9,uint>();
            bvdot_natcheck<N10,uint>();
            bvdot_natcheck<N11,uint>();
            bvdot_natcheck<N12,uint>();
            bvdot_natcheck<N13,uint>();
            bvdot_natcheck<N14,uint>();
            bvdot_natcheck<N15,uint>();
            bvdot_natcheck<N16,uint>();
            bvdot_natcheck<N17,uint>();
            bvdot_natcheck<N18,uint>();
            bvdot_natcheck<N19,uint>();
            bvdot_natcheck<N20,uint>();
            bvdot_natcheck<N21,uint>();
            bvdot_natcheck<N22,uint>();
            bvdot_natcheck<N23,uint>();
            bvdot_natcheck<N24,uint>();
            bvdot_natcheck<N25,uint>();
            bvdot_natcheck<N26,uint>();
            bvdot_natcheck<N27,uint>();
            bvdot_natcheck<N28,uint>();
            bvdot_natcheck<N29,uint>();
            bvdot_natcheck<N30,uint>();
            bvdot_natcheck<N31,uint>();
            bvdot_natcheck<N32,uint>();

        }

        void bvdot_natcheck(ulong t)        
        {
            bvdot_natcheck<N2,ulong>();
            bvdot_natcheck<N3,ulong>();
            bvdot_natcheck<N4,ulong>();
            bvdot_natcheck<N5,ulong>();
            bvdot_natcheck<N6,ulong>();
            bvdot_natcheck<N7,ulong>();
            bvdot_natcheck<N8,ulong>();
            bvdot_natcheck<N9,ulong>();
            bvdot_natcheck<N10,ulong>();
            bvdot_natcheck<N11,ulong>();
            bvdot_natcheck<N12,ulong>();
            bvdot_natcheck<N13,ulong>();
            bvdot_natcheck<N14,ulong>();
            bvdot_natcheck<N15,ulong>();
            bvdot_natcheck<N16,ulong>();
            bvdot_natcheck<N17,ulong>();
            bvdot_natcheck<N18,ulong>();
            bvdot_natcheck<N19,ulong>();
            bvdot_natcheck<N20,ulong>();
            bvdot_natcheck<N21,ulong>();
            bvdot_natcheck<N22,ulong>();
            bvdot_natcheck<N23,ulong>();
            bvdot_natcheck<N24,ulong>();
            bvdot_natcheck<N25,ulong>();
            bvdot_natcheck<N26,ulong>();
            bvdot_natcheck<N27,ulong>();
            bvdot_natcheck<N28,ulong>();
            bvdot_natcheck<N29,ulong>();
            bvdot_natcheck<N30,ulong>();
            bvdot_natcheck<N31,ulong>();
            bvdot_natcheck<N32,ulong>();
            bvdot_natcheck<N33,ulong>();

            bvdot_natcheck<N56,ulong>();
            bvdot_natcheck<N57,ulong>();
            bvdot_natcheck<N58,ulong>();
            bvdot_natcheck<N59,ulong>();            
            bvdot_natcheck<N60,ulong>();
            bvdot_natcheck<N61,ulong>();            
            bvdot_natcheck<N62,ulong>();
            bvdot_natcheck<N64,ulong>();
            bvdot_natcheck<N63,ulong>();
        }


        public void bvdot_4()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n4);
                var y = Random.BitVector(n4);
                var a = x % y;
                var b = modprod(x,y);
                Claim.require(a == b);            
            }
        }

        public void bvdot_8()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                var a = x % y;
                var b = modprod(x,y);
                Claim.require(a == b);            

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                var c = zx % zy;
                Claim.require(a == c);
            }            
        }

        public void bvdot_16()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                var a = x % y;
                var b = modprod(x,y);
                Claim.require(a == b);   

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                var c = zx % zy;
                Claim.require(a == c);
            }
        }

        public void bvdot_32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                var a = x % y;
                var b = modprod(x,y);
                Claim.require(a == b);   

                var zx = x.ToNatural();
                var zy = y.ToNatural();
                var c = zx % zy;
                Claim.require(a == c);
            }
        }

        public void bvdot_64()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                bit a = x % y;
                var b = modprod(x,y);
                Claim.require(a == b);

                var zx = x.ToNatBits();
                var zy = y.ToNatBits();
                bit c = zx % zy;
                Claim.require(a == c);            
            }

            for(var i=0; i< RepCount; i++)          
            {
                var x32 = Random.BitVector(n32);
                var y32 = Random.BitVector(n32);
                var dot32 = BitVector.dot(x32,y32);
                var x64 = x32.Extend(n64);
                var y64 = y32.Extend(n64);
                var dot64 = BitVector.dot(x64,y64);
                Claim.eq(dot32,dot64);
            }
        }

        protected void bvdot_check_n128<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.BitVector(n128, n, t);
                var y = Random.BitVector(n128,n, t);
                CheckNumeric.lteq(x.ToBitString().Nlz(), x.Width);

                var a = x % y;
                var xc = x.ToBitCells();
                var yc = y.ToBitCells();
                var b = xc % yc;
                CheckNumeric.eq(a,b);
            }
        }

        /// <summary>
        /// Verifies the generic bitvector dot product operation
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        protected void bvdot_gcheck<T>(T t = default)
            where T : unmanaged
        {
            var f = BV.bvdot(t);

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.BitVector<T>();
                    var y = Random.BitVector<T>();
                    var actual = f.Invoke(x,y);
                    var expect = BitVector.modprod(x,y);
                    Claim.require(actual == expect);
                    Claim.require(actual == f.InvokeScalar(x,y));
                }
            }

            CheckAction(check, CaseName(f));
        }

        /// <summary>
        /// Verifies the natural bitvector dot product operation
        /// </summary>
        /// <param name="n">The bitvector width</param>
        /// <param name="t">A scalar representative</param>
        /// <typeparam name="N">The bitvector width type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        protected void bvdot_natcheck<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            var opname = $"bvdot_n{n}x{Identify.NumericType<T>()}";

            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.BitVector<N,T>();
                    var y = Random.BitVector<N,T>();
                    bit a = x % y;
                    var b = BitVector.modprod(x,y);
                    Claim.eq(a,b);
                }
            }

            CheckAction(check, Identify.TestCase(GetType(),opname));
        }
    }
}