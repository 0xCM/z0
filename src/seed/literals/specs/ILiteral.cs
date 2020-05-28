//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ILiteral : INullaryKnown, ITextual
    {
        string Name {get;}

        object Data {get;}        

        string Text {get;}

        TypeCode TypeCode {get;}

        Type SystemType {get;}

        bool IsEnum {get;}

        bool MultiLiteral {get;}

        string ITextual.Format() 
            => Text;

        bool IsAnonymous 
            => text.empty(Name);
    }

    public interface ILiteral<F> : ILiteral, INullary<F>, IEquatable<F> 
        where F : struct, ILiteral<F>
    {
        
    }

    public interface ILiteralSource<F>
        where F : ILiteral
    {
        
    }
}