//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    public interface ICheckNumeric : ICheck, ICheckNumericSpan, ICheckNumericComparison, ICheckNumericEquality, INatSpanCheck
    {
        static new ICheckNumeric Checker => default(CheckNumeric);
    }

    public readonly struct CheckNumeric : ICheckNumeric 
    {
        
    }    
}