//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_polyrand<X> : UnitTest<X, CheckVectorBits, ICheckVectorBits>
        where X : t_polyrand<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;
    }
}