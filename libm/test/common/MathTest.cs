//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;


    public class t_libm<T> : UnitTest<T>
        where T : t_libm<T>, new()
    {
        protected override int RoundCount => 1;

        protected override int CycleCount => Pow2.T03;

        protected override int RepCount => Pow2.T08;

    }
}