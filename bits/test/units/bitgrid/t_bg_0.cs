//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class t_bg<X> : t_bits<X>
        where X : t_bg<X>, new()
    {
        protected override int SampleSize => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void bg_define_check<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rows = natval(m);
            var cols = natval(n);
            var points = rows*cols;
            var bytes = points/8 + (points % 8 != 0 ? 1 : 0);
            var bits = bytes*8;
            var segbytes = size<T>();
            var segments = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);

            var grid = BitGrid.alloc(m,n,zero);
            
            for(var i=0; i< SampleSize; i++)
            {
                var input = Random.BitString(grid.PointCount);
                for(var pos=0; pos<input.Length; pos++)
                    grid[pos] = input[pos];

                var output = grid.ToBitString();
                Claim.eq(input,output);                                            
            }

        }

    }

}