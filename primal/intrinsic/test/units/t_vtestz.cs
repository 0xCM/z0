//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class t_vtestz : IntrinsicTest<t_vtestz>
    {


        public void vtestz_g128x8i()
        {
            vtestz_g128_check<sbyte>();
        }

        public void vtestz_g128x8u()
        {
            vtestz_g128_check<byte>();
        }

        public void vtestz_g128x16i()
        {
            vtestz_g128_check<short>();
        }

        public void vtestz_g128x16u()
        {
            vtestz_g128_check<ushort>();
        }

        public void vtestz_g128x32i()
        {
            vtestz_g128_check<int>();
        }

        public void vtestz_g128x32u()
        {
            vtestz_g128_check<uint>();
        }

        public void vtestz_g128x64i()
        {
            vtestz_g128_check<long>();
        }

        public void vtestz_g128x64u()
        {
            vtestz_g128_check<ulong>();
        }

        public void vtestz_g128x32f()
        {
            vtestz_g128_check<float>();
        }

        public void vtestz_g128x64f()
        {
            vtestz_g128_check<double>();
        }

        public void vtestz_g256x8i()
        {
            vtestz_g256_check<sbyte>();
        }

        public void vtestz_g256x8u()
        {
            vtestz_g256_check<byte>();
        }

        public void vtestz_g256x16i()
        {
            vtestz_g256_check<short>();
        }

        public void vtestz_g256x16u()
        {
            vtestz_g256_check<ushort>();
        }

        public void vtestz_g256x32i()
        {
            vtestz_g256_check<int>();
        }

        public void vtestz_g256x32u()
        {
            vtestz_g256_check<uint>();
        }

        public void vtestz_g256x64i()
        {
            vtestz_g256_check<long>();
        }

        public void vtestz_g256x64u()
        {
            vtestz_g256_check<ulong>();
        }

        public void vtestz_g256x32f()
        {
            vtestz_g256_check<float>();
        }

        public void vtestz_g256x64f()
        {
            vtestz_g256_check<double>();
        }


        public void vtestz_g128_check<T>()
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n128);
                var xbs = x.ToBitString();
                var ybs = BitString.Alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = Bit.On;

                var y = ybs.ToCpuVector<T>(n128);

                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

        public void vtestz_g256_check<T>()
            where T : unmanaged
        {
            // Creates a mask corresponding to each off bit in the source vector
            // thereby establishing the the context where testz will return true
            // since all mask-identified source bits are disabled

            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n256);
                var xbs = x.ToBitString();
                var ybs = BitString.Alloc(xbs.Length);
                for(var j = 0; j<xbs.Length; j++)
                    if(!xbs[j])
                        ybs[j] = Bit.On;

                var y = ybs.ToCpuVector<T>(n256);

                var z = ginx.vtestz(x,y);
                Claim.yea(z);
            }
        }

    }
}
