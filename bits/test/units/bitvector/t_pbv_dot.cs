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

    public class t_pbv_dot : t_bv<t_pbv_dot>
    {
        public void pbv_dot_4()
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

        public void pbv_dot_8()
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

        public void pbv_dot_16()
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

        public void pbv_dot_32()
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

        public void pbv_dot_64()
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

    }

}