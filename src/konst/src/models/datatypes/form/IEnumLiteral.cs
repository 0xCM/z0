//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IEnumLiteral : ITextual
    {
        /// <summary>
        /// Specifies the declaration order of the enum literal
        /// </summary>
        int Index {get;}        

        /// <summary>
        /// Specifies the literal identifier
        /// </summary>
        string Identifier {get;}

        /// <summary>
        /// The literal value in an unfortunate box
        /// </summary>
        Enum LiteralValue {get;}        
    
        NumericKind DataType {get;}

        string ITextual.Format()
            => $"{Index.ToString().PadLeft(2, '0')} {LiteralValue}:{Identifier}";        
    }

    /// <summary>
    /// Characterizes a boxed enum value
    /// </summary>
    public interface IEnumLiteral<F> : IEnumLiteral, IEquatable<F>
        where F : IEnumLiteral<F>
         
    {

    }

    /// <summary>
    /// Characterizes an unboxed enum value
    /// </summary>
    public interface IEnumLiteral<F,E> : IEnumLiteral<F>
        where E : unmanaged, Enum
        where F : IEnumLiteral<F,E>
    {
        /// <summary>
        /// The literal value
        /// </summary>
        new E LiteralValue {get;}  

        Enum IEnumLiteral.LiteralValue 
            => LiteralValue;      
    }

    /// <summary>
    /// Characterizes an unboxed enum value, parametric in the enumeration type 
    /// and the underlying numeric type refined by the enum
    /// </summary>
    public interface IEnumLiteral<F,E,V> : IEnumLiteral<F,E>
        where F : IEnumLiteral<F,E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {                
        /// <summary>
        /// The literal value presented as a numeric value
        /// </summary>
        V NumericValue {get;}            
    }
}