//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Used for documentation purposes
    /// </summary>
    enum IdentityIndicatorDocs
    {
        None = 0,

        /// <summary>
        /// A 'x' character between two integer bit-widths
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)' the segment separator delimits a bit-width of 16 and a bit-width of 8
        /// in the identifier 'vnand_(v128x16u,v128x16u)', the segment separator delimits bit-widths 128 and 16 in both value arguments
        /// </example>
        SegSep,

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        ModSep,

        /// <summary>
        /// A separator between type arguments
        /// </summary>
        ArgSep,

        /// <summary>
        /// Indicates a generic type or method
        /// </summary>
        Generic,

        /// <summary>
        /// Indicates a nongeneric type or method
        /// </summary>
        Direct,

        /// <summary>
        /// Indicates a pointer
        /// </summary>
        Pointer,

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        Imm,

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        Signed,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Float,

        /// <summary>
        /// One or more comma-separated parenthetical terms
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the value paramter list is the term sequence 'b16x8u~in,n1,n16'
        /// The parenthesis demarcate/identify the list but are not considered part of the list
        /// </example>
        ValueArgList,

        /// <summary>
        /// An item in a value arg list
        /// </summary>
        ValueArg,

        /// <summary>
        /// One or more comma-separated bracketed terms
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the type arg list is the term '8u'
        /// The brackets demarcate/identify the list but are not considered part of the list
        /// </example>
        TypeArgList,

        /// <summary>
        /// An item in a type arg list
        /// </summary>
        TypeArg,

        /// <summary>
        /// A classifying prefix term
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the letter 'b' in the first value argument indicates 
        /// a (b)locked type; in the identifier 'vnand_(v128x16u,v128x16u)', the letter 'v' initiating each value argument
        /// indicates a (v)ector type (the 'v' in 'vnand' is part of the function name itself, and not part of the indentity syntax)
        /// </example>
        TypeIndicator,    
    }

    /// <summary>
    /// A term that is preceded by a '~' character and which is applicable to the term immediately before the '~' character
    /// </summary>
    /// <example>
    /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the term 'in' is a modifier for the term 'b16x8u'
    /// </example>
    enum TermModifierKind : byte
    {
        None = 0,

        /// <summary>
        /// Modifies a value argument to signify an "in" value
        /// </summary>
        In = 200,

        /// <summary>
        /// Modifies a value argument to signify an "out" value
        /// </summary>
        Out = 201,

        /// <summary>
        /// Modifies a value argument, or return type, to signify a "ref" value
        /// </summary>
        Ref = 202,

        ReadOnly = 203,
        
        First = In,

        Last = ReadOnly,
    }    
}