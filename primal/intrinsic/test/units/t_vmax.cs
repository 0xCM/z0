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


    public class t_vmax : UnitTest<t_vmax>
    {
        void vmax_256x64u_check_example()
        {
            var n = n256;
            
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = Random.CpuVector<ulong>(n);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = BlockedSpan.AllocBlock<ulong>(n);
                for(var i=0; i<zs.Length; i++)
                    zs[i] = gmath.max(xs[i],ys[i]);
                
                var expect = zs.TakeVector();                
                var actual = dinx.vmax(x,y);
                Claim.eq(expect,actual);

                
            }
        }

        public void max_128x8i_check()
            => max_check<sbyte>(n128);

        public void max_128x8u_check()
            => max_check<byte>(n128);

        public void max_128x16i_check()
            => max_check<short>(n128);

        public void max_128x16u_check()
            => max_check<ushort>(n128);

        public void max_128x32i_check()
            => max_check<int>(n128);

        public void max_128x32u_check()
            => max_check<uint>(n128);

        public void max_128x64i_check()
            => max_check<long>(n128);

        public void max_128x64u_check()
            => max_check<ulong>(n128);

        public void max_128x32f_check()
            => max_check<float>(n128);

        public void max_128x64f_check()
            => max_check<double>(n128);

        public void max_256x8i_check()
            => max_check<sbyte>(n256);

        public void max_256x8u_check()
            => max_check<byte>(n256);

        public void max_256x16i_check()
            => max_check<short>(n256);

        public void max_256x16u_check()
            => max_check<ushort>(n256);

        public void max_256x32i_check()
            => max_check<int>(n256);

        public void max_256x32u_check()
            => max_check<uint>(n256);

        public void max_256x64i_check()
            => max_check<long>(n256);

        public void max_256x64u_check()
            => max_check<ulong>(n256);

        public void max_256x32f_check()
            => max_check<float>(n256);

        public void max_256x64f_check()
            => max_check<double>(n256);

        void max_check<T>(N256 n)
            where T : unmanaged
        {

            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = BlockedSpan.AllocBlock<T>(n);
                for(var i=0; i<zs.Length; i++)
                    zs[i] = gmath.max(xs[i],ys[i]);
                
                var expect = zs.TakeVector();                
                var actual = ginx.vmax(x,y);
                Claim.eq(expect,actual);                
            }
        }

        void max_check<T>(N128 n)
            where T : unmanaged
        {

            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = BlockedSpan.AllocBlock<T>(n);
                for(var i=0; i<zs.Length; i++)
                    zs[i] = gmath.max(xs[i],ys[i]);
                
                var expect = zs.TakeVector();                
                var actual = ginx.vmax(x,y);
                Claim.eq(expect,actual);                
            }
        }

    }

}