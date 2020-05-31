//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IAsmExpression<F,T> : ITextual, INullary<F>, INullaryKnown, IEquatable<F>
        where F : struct, IAsmExpression<F,T>
    {
        T Content {get;}
    }
}