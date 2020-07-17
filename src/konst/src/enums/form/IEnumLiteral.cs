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
        uint Position {get;}        

        /// <summary>
        /// Specifies the literal identifier
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The literal value in an unfortunate box
        /// </summary>
        variant ScalarValue {get;}        
    
        NumericKind DataType {get;}

        string ITextual.Format()
            => $"{Position.ToString().PadLeft(2, '0')} {ScalarValue}:{Name}";        
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
        E LiteralValue {get;}  
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