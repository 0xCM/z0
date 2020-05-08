//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public class t_perm : t_bitcore<t_perm>
    {
        public void perm_create_8u()
             => perm_create((byte)5, (byte)100);

        public void perm_swap_8u()
        {
            var id = Perm.identity((byte)32);
            var p = id.Replicate();
            p.Swap(3,4).Swap(4,5).Swap(5,6);
            Claim.eq(p[6], id[3]);
        }

        void perm_create<T>(T m, T n)
            where T : unmanaged
        {
            
            var perm = Perm.identity(n);
            var lengths = gmath.range(m,n);
            Control.iter(lengths, i => {
                var p = Perm.identity(i);
                var cycle = p.Cycle(default(T));
                Claim.eq(cycle.Length, 1);                            
            });

        }
    }
}
