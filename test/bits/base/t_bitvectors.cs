//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_bitvectors<X> : t_bitcore<X>
        where X : t_bitvectors<X>, new()
    {
        protected override int RepCount => Pow2.T08;

        protected override int CycleCount => Pow2.T03;
    }
}