//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbv_seg : t_bv<t_pbv_seg>
    {
        public void pbv_lsbseg_8()
        {
            var width = n8;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.lsbseg(bv,n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void pbv_lsbseg_16()
        {
            var width = n16;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.lsbseg(bv,n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void pbv_lsbseg_32()
        {
            var width = n32;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.lsbseg(bv,n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void pbv_lsbseg_64()
        {
            var width = n64;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.lsbseg(bv,n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void pbv_msbseg_8()
        {
            var width = n8;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.msbseg(bv,n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }

        public void pbv_msbseg_16()
        {
            var width = n16;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.msbseg(bv,n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }


        public void pbv_msbseg_32()
        {
            var width = n32;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.msbseg(bv,n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }

        public void pbv_msbseg_64()
        {
            var width = n64;
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(width);
                var n = Random.Next(1, bv.Width);
                var result = BitVector.msbseg(bv,n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }

    }

}
