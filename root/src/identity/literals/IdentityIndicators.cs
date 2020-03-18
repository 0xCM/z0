//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
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
        /// A suffix part delimiter
        /// </summary>
        public const char SuffixSep = '-';

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        public const char SegSep = 'x';        

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        public const char ModSep = '~';

        /// <summary>
        /// A type or value argument delimiter
        /// </summary>
        public const char ArgSep = ',';

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        public const char Signed = 'i';

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        public const char Unsigned = 'u';

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        public const char Float = 'f';

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        public const char Vector = 'v';

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        public const char Block = 'b';

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        public const char Nat = 'n';

        /// <summary>
        /// Indicates a generic type or method
        /// </summary>
        public const char Generic = 'g';
 
        /// <summary>
        /// Indicates a nongeneric type or method
        /// </summary>
        public const char NonGeneric = 'd';
 
        /// <summary>
        /// Indicates a pointer
        /// </summary>
        public const string Pointer = "ptr";

        /// <summary>
        /// Indicates a span
        /// </summary>
        public const string Span = "span";

        /// <summary>
        /// Indicates an unmodifiable (readonly, immutable, etc) span
        /// </summary>
        public const string USpan = "uspan";

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        public const string NSpan = "nspan";

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        public const string Imm = "imm";        

        public const char ValueArgsOpen = '(';

        public const char ValueArgsClose = ')';

        public const char TypeArgsOpen = '[';

        public const char TypeArgsClose = ']';

        public const char SizeArgOpen = '{';

        public const char SizeArgClose = '}';
    }
}