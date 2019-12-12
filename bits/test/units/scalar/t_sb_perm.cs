//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_perm : t_sb<t_sb_perm>
    {
        public void perm_create()
        {

            perm_create(5,20);
            perm_create((byte)5,(byte)100);
            perm_create((sbyte)5, (sbyte)100);
            perm_create((short)5, (short)100);
            perm_create((ulong)5, (ulong)100);
        }

        public void perm_swap()
        {
            var id = Perm.identity((byte)32);
            var p = id.Replicate();
            p.Swap(3,4).Swap(4,5).Swap(5,6);
            Claim.eq(p[6], id[3]);
        }

        void perm_create<T>(T m, T n)
            where T : unmanaged
        {
            
            var perm = PermSpec<T>.identity(n);
            var lengths = range(m,n);
            iter(lengths, i => {
                var p = PermSpec<T>.identity(i);
                var cycle = p.Cycle(default(T));
                Claim.eq(cycle.Length, 1);                            
            });

        }
    }
}
