//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ILiteral : INullaryKnown, ITextual
    {
        string Name {get;}

        object Data {get;}        

        string Text {get;}

        bool MultiLiteral
             => false;

        Type SystemType  
            => Data.GetType();

        TypeCode TypeCode 
            => Type.GetTypeCode(SystemType);

        bool IsEnum  
            => SystemType.IsEnum;


        string ITextual.Format() 
            => Text;

        bool IsAnonymous 
            => string.IsNullOrWhiteSpace(Name);
    }

    public interface ILiteral<F> : ILiteral, INullary<F>, IEquatable<F> 
        where F : struct, ILiteral<F>
    {
        
    }

    public interface ILiteral<F,T> : ILiteral<F> 
        where F : struct, ILiteral<F,T>
    {
        new T Data {get;}

        object ILiteral.Data => Data;
    }
}