//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class t_libm<T> : UnitTest<T,CheckNumeric,ICheckNumeric>    
        where T : t_libm<T>, new()
    {
        protected override int RoundCount => 1;

        protected override int CycleCount => Pow2.T03;

        protected override int RepCount => Pow2.T08;

        ICheckClose CheckClose => Z0.CheckClose.Checker;

    }
}