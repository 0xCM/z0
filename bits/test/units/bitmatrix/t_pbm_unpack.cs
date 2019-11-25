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
    
    using static zfunc;

    public class t_pbm_unpack : BitMatrixTest<t_pbm_unpack>
    {
        public void pbm_unpack_8()
        {
            var dst = Matrix.alloc<N8,byte>();
            var m = dst.ColCount;
            var n = dst.RowCount;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var src = Random.BitMatrix8();
                BitMatrix.unpack(src, ref dst);
                
                for(var i=0; i< m; i++)
                for(var j=0; j< n; j++)
                    Claim.eq(src[i,j], dst[i,j] == 0 ? Bit.Off : Bit.On);
            }
        }

        public void pbm_unpack_64()
        {
            var dst = Matrix.alloc<N64,ulong>();
            var m = dst.ColCount;
            var n = dst.RowCount;
            for(var sample=0; sample<SampleSize; sample++)
            {
                var src = Random.BitMatrix64();
                BitMatrix.unpack(src, ref dst);
                
                for(var i=0; i< m; i++)
                for(var j=0; j< n; j++)
                    Claim.eq(src[i,j], dst[i,j] == 0 ? bit.Off : bit.On);

            }
        }
    }
}