//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitVector;

    public abstract class t_bv<X> : UnitTest<t_bv<X>>
        where X : t_bv<X>, new()
    {
        protected override int RepCount => Pow2.T08;

        protected override int CycleCount => Pow2.T03;







    }
}