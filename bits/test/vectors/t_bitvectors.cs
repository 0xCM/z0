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

    public abstract class t_bitvectors<X> : UnitTest<t_bitvectors<X>>
        where X : t_bitvectors<X>, new()
    {
        protected override int RepCount => Pow2.T08;

        protected override int CycleCount => Pow2.T03;


    }
}