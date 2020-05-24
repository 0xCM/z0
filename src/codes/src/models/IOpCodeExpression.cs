//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IOpCodeComponent<F,T> : ITextual, INullary<F>, INullaryKnown, IEquatable<F>
        where F : struct, IOpCodeComponent<F,T>
    {
        T Content {get;}
    }

    public interface IOpCodeExpression<F,T> : IOpCodeComponent<F,T>
        where F : struct, IOpCodeExpression<F,T> 
    {        
        ReadOnlySpan<char> Data {get;}                
    }
}