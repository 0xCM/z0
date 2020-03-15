//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using IIK = IdentityIndicatorKind;

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

}