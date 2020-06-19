//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IExpressional : INullity, ITextual
    {

    }
    
    public interface IExpressional<T> : IExpressional
    {
        T Body {get;}       
    }

    public interface IExpressional<F,T> :  IExpressional<T>, INullary<F>, IEquatable<F>
        where F : struct, IExpressional<F,T>
    {

    }
}