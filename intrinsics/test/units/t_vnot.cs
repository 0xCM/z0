//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vnot : IntrinsicTest<t_vnot>
    {
        public void vnot_check_128()
        {
            var n = n128;
            vnot_check<byte>(n);
            vnot_check<sbyte>(n);
            vnot_check<short>(n);
            vnot_check<ushort>(n);
            vnot_check<int>(n);
            vnot_check<uint>(n);
            vnot_check<long>(n);
            vnot_check<ulong>(n);
        }

        public void vnot_check_256()
        {
            var n = n256;
            vnot_check<byte>(n);
            vnot_check<sbyte>(n);
            vnot_check<short>(n);
            vnot_check<ushort>(n);
            vnot_check<int>(n);
            vnot_check<uint>(n);
            vnot_check<long>(n);
            vnot_check<ulong>(n);
        }

        void vnot_check<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);

                var actual = ginx.vnot(x);
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();
                var expect  = ginx.vload(n, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);
            }
        }

        void vnot_check<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var actual = ginx.vnot(x);
                var bsX = x.ToBitString();
                var bsY = actual.ToBitString();
                Claim.eq(bsX.Length, bsY.Length);
                for(var j=0; j< bsX.Length; j++)
                    Claim.neq(bsX[j],bsY[j]);

                var xData = x.ToSpan();                
                var expect  = ginx.vload(n, in head(mathspan.not(xData)));
                Claim.eq(expect,actual);


            }
        }
    }

}