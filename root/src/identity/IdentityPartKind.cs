//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum IdentityPartKind : ushort
    {
        None = 0,
                
        /// <summary>
        /// The unadorned subject name and the first part of the moniker
        /// </summary>
        Name = 1,
                
        /// <summary>
        /// A trailing component of the form {suffix sep}{suffix name}
        /// </summary>
        Suffix = 4,
        
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
        /// Modifies a value argument to signify an "in" value
        /// </summary>
        InTermModifier = TermModifierKind.In,

        /// <summary>
        /// Modifies a value argument to signify an "out" value
        /// </summary>
        OutTermModifier = TermModifierKind.Out,

        /// <summary>
        /// Modifies a value argument, or return type, to signify a "ref" value
        /// </summary>
        RefTermModifier = TermModifierKind.Ref,
        
        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        SignedIndicator = IdentityIndicatorKind.Signed,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        UnsignedIndicator = IdentityIndicatorKind.Unsigned,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        FloatIndicator = IdentityIndicatorKind.Float,

        /// <summary>
        /// A numeric specifier of the form {width}{numeric_indicator}
        /// </summary>
        /// <example>
        /// In the identifier 'gteq_(8u,8u)' both arguments are 8-bit unsigned scalar values
        /// </example>
        Scalar,

        /// <summary>
        /// A classifying prefix term
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the letter 'b' in the first value argument indicates 
        /// a (b)locked type; in the identifier 'vnand_(v128x16u,v128x16u)', the letter 'v' initiating each value argument
        /// indicates a (v)ector type (the 'v' in 'vnand' is part of the function name itself, and not part of the indentity syntax)
        /// </example>
        TypeIndicator,
        
        /// <summary>
        /// A '-' character in an identifier
        /// </summary>
        PartSep,

        /// <summary>
        /// A 'x' character between two integer bit-widths
        /// </summary>
        /// <example>
        /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)' the segment separator delimits a bit-width of 16 and a bit-width of 8
        /// in the identifier 'vnand_(v128x16u,v128x16u)', the segment separator delimits bit-widths 128 and 16 in both value arguments
        /// </example>
        SegSep,

        /// <summary>
        /// A segmentation specifier of the form {total width}x{segment width}{numeric indicator}
        /// </summary>
        /// <example>
        /// in the identifier 'vnand_(v128x16u,v128x16u)', the term '128x16u' in both value arguments is a segment specifier
        /// </example>
        Segment ,
    }


    public static class IdentityPartKindOps
    {
        [MethodImpl(Inline)]
        public static bool IsNumericIndicator(this IdentityPartKind kind)
            => kind == IdentityPartKind.FloatIndicator 
            || kind == IdentityPartKind.UnsignedIndicator 
            || kind == IdentityPartKind.SignedIndicator;

        [MethodImpl(Inline)]
        public static bool IsArgList(this IdentityPartKind kind)
            => kind == IdentityPartKind.ValueArgList 
            || kind == IdentityPartKind.TypeArgList;

        [MethodImpl(Inline)]
        public static bool IsArg(this IdentityPartKind kind)
            => kind == IdentityPartKind.ValueArg
            || kind == IdentityPartKind.TypeArg;
        
        [MethodImpl(Inline)]
        public static bool IsModifier(this IdentityPartKind kind)
            => (TermModifierKind)kind >= TermModifierKind.First 
            && (TermModifierKind)kind <= TermModifierKind.Last;
    }    
}