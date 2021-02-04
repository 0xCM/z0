//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    public class t_vclear :  t_inx<t_vconvert>
    {
        public void vclear_128x8()
            => vclear_check(n128,z8);

        public void vclear_128x32()
            => vclear_check(n128,z32);

        public void vclear_256x8()
            => vclear_check(n256,z8);

        public void vclear_256x16()
            => vclear_check(n256,z16);

        public void vclear_256x32()
            => vclear_check(n256,z32);

        public void vclear_256x64()
            => vclear_check(n256,z16);

        public void vclear_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                byte start = Random.Next<byte>(0, (byte)bitwidth<T>());
                byte length = (byte)(bitwidth<T>() - start);
                var cellcount = n/bitwidth(t);
                var x = Random.CpuVector<T>(n);
                var x1 = gvec.vbitclear(x, start, length);
                var x2 = gvec.vsrl(x1,start);
                Claim.nea(gcpu.vnonz(x2));
            }
        }

        protected void vclear_check<T>(N128 n, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                byte start = Random.Next<byte>(0, (byte)bitwidth<T>());
                byte length = (byte)(bitwidth<T>() - start);
                var cellcount = n/bitwidth(t);
                var x = Random.CpuVector<T>(n);
                var x1 = gvec.vbitclear(x, start, length);
                var x2 = gvec.vsrl(x1,start);
                Claim.nea(gcpu.vnonz(x2));
            }
        }

        public void clearalt_256x8()
        {
            var tr = gcpu.vclearalt<byte>(n256);
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = cpu.vshuf16x8(x, tr);
                var xs = x.ToBlock();
                for(var j =0; j< xs.CellCount; j++)
                {
                    if(j % 2 != 0)
                        xs[j] = 0;
                }

                var xt = xs.LoadVector();

                Claim.veq(xt,y);
            }
        }
    }
}