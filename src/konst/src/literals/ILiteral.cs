//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Describes a literal value from a non-parametric perspective
    /// </summary>
    public interface ILiteral : INullity, ITextual
    {
        /// <summary>
        /// A locally-scoped identifier
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The literal data
        /// </summary>
        object Data {get;}        

        /// <summary>
        /// The literal's text representation
        /// </summary>
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

    /// <summary>
    /// Characterizes a reified literal description
    /// </summary>
    public interface ILiteral<F> : ILiteral, INullary<F>, IEquatable<F> 
        where F : struct, ILiteral<F>
    {
        
    }

    /// <summary>
    /// Characterizes a reified T-parametric literal description
    /// </summary>
    public interface ILiteral<F,T> : ILiteral<F> 
        where F : struct, ILiteral<F,T>
    {
        /// <summary>
        /// The literal data
        /// </summary>
        new T Data {get;}

        object ILiteral.Data 
            => Data;
    }
}