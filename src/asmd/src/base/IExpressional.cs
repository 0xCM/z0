//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IExpressional<F,T> : ITextual, INullary<F>, INullaryKnown, IEquatable<F>
        where F : struct, IExpressional<F,T>
    {
        T Data {get;}       
    }
}