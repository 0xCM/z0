//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    using static Chars;

    /// <summary>
    /// Identity indicators
    /// </summary>
    public static class IDI
    {
        /// <summary>
        /// An identity part delimiter
        /// </summary>
        public const char PartSep = Underscore;

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        public const char SuffixSep = Dash;

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        public const char SegSep = 'x';

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        public const char ModSep = Tilde;

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
        /// A type or value argument delimiter
        /// </summary>
        public const char ArgSep = Comma;

        public const char ArgSepAlt = SymNot.Dot;

        /// <summary>
        /// Opens a value parameter list
        /// </summary>
        public const char ArgsOpen = LParen;

        public const char ArgsOpenAlt = SymNot.Circle;

        /// <summary>
        /// Closes a value parameter list
        /// </summary>
        public const char ArgsClose = RParen;

        public const char ArgsCloseAlt = SymNot.Circle;

        /// <summary>
        /// Opens a type argument list
        /// </summary>
        public const char TypeArgsOpen = LBracket;

        public const char TypeArgsOpenAlt = SymNot.Lt;

        /// <summary>
        /// Closes a type argument list
        /// </summary>
        public const char TypeArgsClose = RBracket;

        public const char TypeArgsCloseAlt = SymNot.Gt;

        /// <summary>
        /// The text used to terminate a uri scheme and trailing '//'
        /// </summary>
        public const string EndOfScheme = "://";

        /// <summary>
        /// The symbol used to separate uri path components
        /// </summary>
        public const char UriPathSep = Chars.FSlash;        

        /// <summary>
        /// The symbol used to delimit a uri query segment from the path
        /// </summary>
        public const char UriQueryMarker = Chars.Question;

        /// <summary>
        /// The symbol used to announce a fragment
        /// </summary>
        public const char UriFragment = Chars.Hash;

        /// <summary>
        /// Indicates a pointer
        /// </summary>
        public const string Pointer = "ptr";

        /// <summary>
        /// Indicates a span
        /// </summary>
        public const string Span = "span";

        /// <summary>
        /// Indicates an array
        /// </summary>
        public const string Array = "arr";

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

        public const string GenericLocator = "_g";

        public const string AsmLocator = "-asm";   
    }
}