//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISymbolic : IExpressional
    {

    }
    
    public interface ISymbolic<S> : ISymbolic, IExpressional<S>
        where S : unmanaged
    {

    }
    
    public interface ISymbolic<F,S> :  ISymbolic<S>, IExpressional<F,S>
        where F : struct, ISymbolic<F,S>
        where S : unmanaged
    {

    }
}