//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IExpressional
    {

    }
    
    public interface IExpressional<T> : IExpressional
    {
        T Data {get;}       
    }

    public interface IExpressional<F,T> :  IExpressional<T>, ITextual, INullary<F>, INullaryKnown, IEquatable<F>
        where F : struct, IExpressional<F,T>
    {

    }
}