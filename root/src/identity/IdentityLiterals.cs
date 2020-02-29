//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    using IIK = IdentityIndicatorKind;

    public enum IdentityKind
    {
        None = 0,

        Type,

        Operation,
    }
    
    public enum OpUriScheme
    {
        None = 0,
        
        Asm,

        Hex,

        Raw,

        Cil

    }

    [Flags]
    public enum ApiHostKind
    {
        None = 0,

        Direct = 1,

        Generic = 2,

        DirectAndGeneric = Direct | Generic
    }

    /// <summary>
    /// A term that is preceded by a '~' character and which is applicable to the term immediately before the '~' character
    /// </summary>
    /// <example>
    /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the term 'in' is a modifier for the term 'b16x8u'
    /// </example>
    public enum TermModifierKind : ushort
    {
        None = 0,

        In = 200,

        Out = 201,

        Ref = 202,

        ReadOnly = 203,
        
        First = In,

        Last = ReadOnly,
    }

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

    /// <summary>
    /// Identity indicators
    /// </summary>
    public static class IDI
    {
        /// <summary>
        /// An identity part delimiter
        /// </summary>
        public const char PartSep = '_';

        /// <summary>
        /// An identity part delimiter expressed as text
        /// </summary>
        [IdentityIndicator(IIK.PartSep)]
        public const string PartSepText = "_";

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        public const char SuffixSep = '-';

        /// <summary>
        /// A suffix part delimiter expressed as text
        /// </summary>
        [IdentityIndicator(IIK.SuffixSep)]
        public const string SuffixSepText = "-";

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        public const char SegSep = 'x';        

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment expressed as text
        /// </summary>
        [IdentityIndicator(IIK.SegSep)]
        public const string SegSepText = "x";        

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        public const char ModSep = '~';

        /// <summary>
        /// A separator between an identifier body and an applied modifier expressed as text
        /// </summary>
        [IdentityIndicator(IIK.ModSep)]
        public const string ModSepText = "~";

        /// <summary>
        /// A type or value argument delimiter
        /// </summary>
        public const char ArgSep = ',';

        /// <summary>
        /// The argument delimiter as text
        /// </summary>
        [IdentityIndicator(IIK.ArgSep)]
        public const string ArgSepText = ",";

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        public const char Signed = 'i';

        /// <summary>
        /// Indicates a signed integral type expressed as text
        /// </summary>
        [IdentityIndicator(IIK.Signed)]
        public const string SignedText = "i";

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        public const char Unsigned = 'u';

        /// <summary>
        /// Indicates an unsigned integral type expressed as text
        /// </summary>
        [IdentityIndicator(IIK.Unsigned)]
        public const string UnsignedText = "u";

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        public const char Float = 'f';

        /// <summary>
        /// Indicates a floating-point type expressed as text
        /// </summary>
        [IdentityIndicator(IIK.Float)]
        public const string FloatText = "f";

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        public const char Vector = 'v';

        /// <summary>
        /// Indicates an intrinsic vector expressed as text
        /// </summary>        
        [IdentityIndicator(IIK.Vector)]
        public const string VectorText = "v";

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        public const char Block = 'b';

        /// <summary>
        /// A block type indicator expressed as text
        /// </summary>        
        [IdentityIndicator(IIK.Block)]
        public const string BlockText = "b";

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        public const char Nat = 'n';

        /// <summary>
        /// A nat type indicator expressed as text
        /// </summary>        
        [IdentityIndicator(IIK.Nat)]
        public const string NatText = "n";

        /// <summary>
        /// Indicates a generic type or method
        /// </summary>
        public const char Generic = 'g';

        /// <summary>
        /// A generic indicator expressed as text
        /// </summary>
        [IdentityIndicator(IIK.Generic)]
        public const string GenericText = "g";

        /// <summary>
        /// Indicates a nongeneric type or method
        /// </summary>
        public const char NonGeneric = 'd';

        /// <summary>
        /// A nongeneric indicator expressed as text
        /// </summary>
        [IdentityIndicator(IIK.Direct)]
        public const string NonGenericText = "d";

        /// <summary>
        /// Indicates a pointer
        /// </summary>
        [IdentityIndicator(IIK.Pointer)]
        public const string Pointer = "ptr";

        /// <summary>
        /// Indicates a span
        /// </summary>
        [IdentityIndicator(IIK.Span)]
        public const string Span = "span";

        /// <summary>
        /// Indicates an unmodifiable (readonly, immutable, etc) span
        /// </summary>
        [IdentityIndicator(IIK.USpan)]
        public const string USpan = "uspan";

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        [IdentityIndicator(IIK.NSpan)]
        public const string NSpan = "nspan";

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        [IdentityIndicator(IIK.Imm)]
        public const string Imm = "imm";        

        public const char ValueArgsOpen = '(';

        public const char ValueArgsClose = ')';

        public const char TypeArgsOpen = '[';

        public const char TypeArgsClose = ']';

        public const char SizeArgOpen = '{';

        public const char SizeArgClose = '}';
    }

    /// <summary>
    /// Defines character representations of the partitions identified by the NumericClass kind
    /// </summary>
    public enum NumericIndicator : ushort
    {
        None = 0,        
        
        /// <summary>
        /// 105: Indicates a signed integral type
        /// </summary>
        Signed = (ushort)IDI.Signed,

        /// <summary>
        /// 102: Indicates a floating-point type
        /// </summary>
        Float = (ushort)IDI.Float,

        /// <summary>
        /// 117: Indicates an unsigned integral type
        /// </summary>
        Unsigned =  (ushort)IDI.Unsigned,
    }

    public enum TypeIndicatorKind : ushort
    {
        None = 0,

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        Vector = 250,

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        Block = 251,

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        Nat = 252,

        /// <summary>
        /// Indicates a span
        /// </summary>
        Span = 253,

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        USpan = 254,

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        NSpan = 255,        
    }

    public enum IdentityIndicatorKind : ushort
    {
        None = 0,

        /// <summary>
        /// An identity part delimiter
        /// </summary>
        PartSep,

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        SuffixSep,

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
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
        /// Indicates an intrinsic vector
        /// </summary>        
        Vector = TypeIndicatorKind.Vector,

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        Block = TypeIndicatorKind.Block,

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        Nat = TypeIndicatorKind.Nat,

        /// <summary>
        /// Indicates a span
        /// </summary>
        Span = TypeIndicatorKind.Span,

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        USpan = TypeIndicatorKind.USpan,

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        NSpan = TypeIndicatorKind.NSpan,

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
        Signed = NumericIndicator.Signed,

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        Unsigned = NumericIndicator.Unsigned,

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        Float = NumericIndicator.Float,
    }
}