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
        public void cmp_lt_128x8i_check()
            => cmp_lt_check<sbyte>(n128);

        public void cmp_lt_128x8u_check()
            => cmp_lt_check<byte>(n128);

        public void cmp_lt_128x16i_check()
            => cmp_lt_check<short>(n128);

        public void cmp_lt_128x16u_check()
            => cmp_lt_check<ushort>(n128);

        public void cmp_lt_128x32i_check()
            => cmp_lt_check<int>(n128);

        public void cmp_lt_128x32u_check()
            => cmp_lt_check<uint>(n128); 

        public void cmp_lt_128x64i_check()
            => cmp_lt_check<long>(n128); 

        public void cmp_lt_128x64u_check()
            => cmp_lt_check<ulong>(n128); 

        public void cmp_lt_256x8i_check()
            => cmp_lt_check<sbyte>(n256);

        public void cmp_lt_256x8u_check()
            => cmp_lt_check<byte>(n256);

        public void cmp_lt_256x16i_check()
            => cmp_lt_check<short>(n256);

        public void cmp_lt_256x16u_check()
            => cmp_lt_check<ushort>(n256);

        public void cmp_lt_256x32i_check()
            => cmp_lt_check<int>(n256);

        public void cmp_lt_256x32u_check()
            => cmp_lt_check<uint>(n256);

        public void cmp_lt_256x64i_check()
            => cmp_lt_check<long>(n256);

        public void cmp_lt_256x64u_check()
            => cmp_lt_check<ulong>(n256);

        void cmp_lt_check<T>(N128 n = default)
            where T : unmanaged
        {
            var ones = ginx.vpOnes<T>(n);
            var one = ginx.vextract(ones,0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BlockedSpan<T>(n);
                var y = Random.BlockedSpan<T>(n);
                var z = BlockedSpan.AllocBlock<T>(n);
                
                for(var j=0; j<z.Length; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;

                var expect = ginx.vloadu(n, in head(z));
                var actual = ginx.vcmplt(x.LoadVector(),y.LoadVector());
                var result = ginx.vcmpeq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

        void cmp_lt_check<T>(N256 n = default)
            where T : unmanaged
        {
            var ones = ginx.vpOnes<T>(n);
            var one = ginx.vextract(ginx.vlo(ones),0);
            
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BlockedSpan<T>(n);
                var y = Random.BlockedSpan<T>(n);
                var z = BlockedSpan.AllocBlock<T>(n);
                
                for(var j=0; j<z.Length; j++)
                    if(gmath.lt(x[j],y[j]))
                        z[j] = one;
                
                var expect = ginx.vloadu(n, in head(z));
                var actual = ginx.vcmplt(x.LoadVector(),y.LoadVector());
                var result = ginx.vcmpeq(expect,actual);
                var equal = ginx.vtestc(result,ones);
                Claim.yea(equal);       

            }
        }

    }


}