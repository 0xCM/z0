//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsrl : IntrinsicTest<t_vsrl>
    {
        public void vsrl_128x8u()
            => vsrl_check<byte>(n128);

        public void vsrl_128x8u_bench()
            => vsrl_bench<byte>(n128);

        public void vsrl_128x16u()
            => vsrl_check<ushort>(n128);

        public void vsrl_128x16u_bench()
            => vsrl_bench<ushort>(n128);

        public void vsrl_128x32u()
            => vsrl_check<uint>(n128);

        public void vsrl_128x32u_bench()
            => vsrl_bench<uint>(n128);

        public void vsrl_128x64u()
            => vsrl_check<ulong>(n128);

        public void vsrl_128x64u_bench()
            => vsrl_bench<ulong>(n128);

        public void vsrl_256x8u()
            => vsrl_check<byte>(n256);

        public void vsrl_256x16u()
            => vsrl_check<ushort>(n256);

        public void vsrl_256x32u()
            => vsrl_check<uint>(n256);

        public void vsrl_256x64u()
            => vsrl_check<ulong>(n256);

        public void vsrl_256x8u_bench()
            => vsrl_bench<byte>(n256);

        public void vsrl_256x16u_bench()
            => vsrl_bench<ushort>(n256);

        public void vsrl_256x32u_bench()
            => vsrl_bench<uint>(n256);

        public void vsrl_256x64u_bench()
            => vsrl_bench<ulong>(n256);

        void vsrl_check<T>(N128 n)
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n);
                var offset = Random.Next<byte>(2,7);
                var dst = ginx.vsrl(src,offset);
                for(var j=0; j<dst.Length(); j++)
                {
                    var x = vcell(dst, (byte)j);
                    var y = vcell(src, (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));
                }
            }
        }

        void vsrl_check<T>(N256 n)
            where T : unmanaged
        {

            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.CpuVector<T>(n);
                var offset = Random.Next<byte>(2,7);
                var vOffset = ginx.vscalar(convert<byte,T>(offset));

                var a = ginx.vsrl(src, offset);
                var b = ginx.vsrl(src, vOffset);
                Claim.eq(a,b);

                for(var j=0; j<a.Length()/2; j++)
                {
                    var x = vcell(ginx.vlo(a), (byte)j);
                    var y = vcell(ginx.vlo(src), (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));

                    x = vcell(ginx.vhi(a), (byte)j);
                    y = vcell(ginx.vhi(src), (byte)j);
                    Claim.eq(x, gmath.srl(y,offset));

                }
            }
        }

        void vsrl_bench<T>(N128 n)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(n);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"srl_{n}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n);
                sw.Start();
                last = ginx.vsrl(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));

        }

        void vsrl_bench<T>(N256 n)
            where T : unmanaged
        {
            var opcount = RoundCount * CycleCount;
            var last = vzero<T>(n);
            var sw = stopwatch(false);
            var bitlen = bitsize<T>();
            var opname = $"srl_{n}x{bitlen}u";

            for(var i=0; i<opcount; i++)
            {
                var offset = Random.Next<byte>(2, (byte)(bitlen - 1));
                var x = Random.CpuVector<T>(n);
                sw.Start();
                last = ginx.vsrl(x,offset);
                sw.Stop();
            
            }
            Collect((opcount, sw, opname));
        }        
    }
}