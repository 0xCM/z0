//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_bitsvc<X> : UnitTest<X,CheckVectors,ICheckVectors>
        where X : t_bitsvc<X>, new()
    {
        protected override int RepCount => Pow2.T08;

        protected override int CycleCount => Pow2.T03;
    }
}