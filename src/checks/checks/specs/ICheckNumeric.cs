//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    public interface ICheckNumeric : ICheck, ICheckNumericSpan, ICheckNumericComparison, ICheckNumericEquality
    {
        static new ICheckNumeric<CheckNumeric> Checker => CheckNumeric.Check;
    }

    public interface ICheckNumeric<C> : ICheckNumeric, ICheck<C>
        where C : ICheckNumeric<C>, new()
    {
        
    }

}