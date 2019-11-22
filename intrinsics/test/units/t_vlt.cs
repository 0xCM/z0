//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class t_vlt : IntrinsicTest<t_vlt>
    {        
        public void vlt_128x8i()
            => vlt_check<sbyte>(n128);

        public void vlt_128x8u()
            => vlt_check<byte>(n128);

        public void vlt_128x16i()
            => vlt_check<short>(n128);

        public void vlt_128x16u()
            => vlt_check<ushort>(n128);

        public void vlt_128x32i()
            => vlt_check<int>(n128);

        public void vlt_128x32u()
            => vlt_check<uint>(n128); 

        public void vlt_128x64i()
            => vlt_check<long>(n128); 

        public void vlt_128x64u()
            => vlt_check<ulong>(n128); 

        public void vlt_256x8i()
            => vlt_check<sbyte>(n256);

        public void vlt_256x8u()
            => vlt_check<byte>(n256);

        public void vlt_256x16i()
            => vlt_check<short>(n256);

        public void vlt_256x16u()
            => vlt_check<ushort>(n256);

        public void vlt_256x32i()
            => vlt_check<int>(n256);

        public void vlt_256x32u()
            => vlt_check<uint>(n256);

        public void vlt_256x64i()
            => vlt_check<long>(n256);

        public void vlt_256x64u()
            => vlt_check<ulong>(n256);

        void vlt_check<T>(N128 n)
            where T : unmanaged
        {
            var ones = ginx.vones<T>(n);
            var one = vcell(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.Length; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        void vlt_check<T>(N256 n)
            where T : unmanaged
        {
            var ones = ginx.vones<T>(n);
            var one = vcell(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.Blocks<T>(n);
                var y = Random.Blocks<T>(n);
                var z = DataBlocks.alloc<T>(n);
                
                for(var j=0; j<z.Length; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vload(n, in head(z));
                var actual = ginx.vlt(x.LoadVector(),y.LoadVector());
                var result = ginx.veq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }
    }
}