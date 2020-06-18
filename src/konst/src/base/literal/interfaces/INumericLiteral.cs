//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INumericLiteral : ILiteral
    {
        
    }

    public interface INumericLiteral<F> : INumericLiteral, ILiteral<F>
        where F : struct, INumericLiteral<F>
    {
    }

    public interface INumericLiteral<F,T> : INumericLiteral<F>, ILiteral<F,T>
        where F : struct, INumericLiteral<F,T>
        where T : unmanaged
    {

    }    
}