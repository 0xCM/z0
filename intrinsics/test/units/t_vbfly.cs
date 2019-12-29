//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vbfly : t_vinx<t_vbfly>
    {
        public void vbutterfly_128x32x4()
        {
            var n = n128;
            var w = n4;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = ginx.vbfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.single<uint>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.eq(z,y);
            }
        }

        public void vbutterfly_256x32x4()
        {
            var n = n256;
            var w = n4;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n);
                var y = ginx.vbfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.single<uint>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.eq(z,y);

            }
        }

        public void vbutterfly_128x64x1()
        {
            var n = n128;
            var w = n1;
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<ulong>(n);
                var y = ginx.vbfly(w, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.single<ulong>(n);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(w,xs[j]);
                var z = zs.LoadVector();
                Claim.eq(z,y);
            }
        }

        public void vbutterfly_256x64x1()
            => vbutterfly_check(n256, n1, z64);

        protected void vbutterfly_check<T>(N256 w, N1 b, T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.CpuVector<T>(w);
                var y = ginx.vbfly(b, x);
                var xs = x.ToSpan();
                var zs = DataBlocks.single<T>(w);
                for(var j=0; j<zs.CellCount; j++)
                    zs[j] = gbits.bfly(b,xs[j]);
                var z = zs.LoadVector();
                Claim.eq(z,y);
            }
        }



    }

}