//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static RootShare;
    using IIK = IdentityIndicatorKind;


    /// <summary>
    /// Identity indicators
    /// </summary>
    public static class IDI
    {
        public static IIK ParseKind(string src)
        {
            return src switch
            {
                IDI.PartSepText => IIK.PartSep,
                IDI.SuffixSepText => IIK.SuffixSep,
                IDI.SegSepText => IIK.SegSep,
                IDI.SignedText => IIK.Signed,
                IDI.UnsignedText => IIK.Unsigned,
                IDI.FloatText => IIK.Float,
                IDI.VectorText => IIK.Vector,
              
                _ => IIK.None
            };
        }

        /// <summary>
        /// An identity part delimiter
        /// </summary>
        public const char PartSep = '_';

        /// <summary>
        /// An identity part delimiter
        /// </summary>
        public const string PartSepText = "_";

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        public const char SuffixSep = '-';

        /// <summary>
        /// A suffix part delimiter
        /// </summary>
        public const string SuffixSepText = "-";

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        public const char SegSep = 'x';        

        /// <summary>
        /// A separator between the bit width of a segmented type and the width of each segment
        /// </summary>
        public const string SegSepText = "x";        

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        public const char Signed = (char)NumericIndicator.Signed;

        /// <summary>
        /// Indicates a signed integral type
        /// </summary>
        public const string SignedText = "i";

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        public const char Unsigned = (char)NumericIndicator.Unsigned;

        /// <summary>
        /// Indicates an unsigned integral type
        /// </summary>
        public const string UnsignedText = "u";

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        public const char Float = (char)NumericIndicator.Float;

        /// <summary>
        /// Indicates a floating-point type
        /// </summary>
        public const string FloatText = "f";

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        public const char Vector = 'v';

        /// <summary>
        /// Indicates an intrinsic vector
        /// </summary>        
        public const string VectorText = "v";

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        public const char Block = 'b';

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        public const string BlockText= "b";

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
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        public const string Modifier = "~";

        /// <summary>
        /// Indicats a pointer
        /// </summary>
        public const string Pointer = "ptr";

        /// <summary>
        /// Indicates a span
        /// </summary>
        public const string Span = "span";

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        public const string ImSpan = "imspan";

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        public const string NatSpan = "nspan";

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        public const string Imm = "imm";        
    }

    public enum IdentityIndicatorKind
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
        /// Indicates an intrinsic vector
        /// </summary>        
        Vector,

        /// <summary>
        /// Indicates a blocked type
        /// </summary>        
        Block,

        /// <summary>
        /// Indicates a natural number type
        /// </summary>        
        Nat,

        /// <summary>
        /// Indicates a generic type or method
        /// </summary>
        Generic,

        /// <summary>
        /// Indicates a nongeneric type or method
        /// </summary>
        NonGeneric,

        /// <summary>
        /// A separator between an identifier body and an applied modifier
        /// </summary>
        Modifier,

        /// <summary>
        /// Indicats a pointer
        /// </summary>
        Pointer,

        /// <summary>
        /// Indicates a span
        /// </summary>
        Span,

        /// <summary>
        /// Indicates a readonly span
        /// </summary>
        ImSpan,

        /// <summary>
        /// Indicates a natural span
        /// </summary>
        NatSpan,

        /// <summary>
        /// An identifier suffix indicating that an immediate value is required
        /// </summary>
        Imm,

    }

    partial class RootKindExtensions
    {
        [MethodImpl(Inline)]
        public static bool IsSome(this IdentityIndicatorKind kind)
            => kind != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this IdentityIndicatorKind kind)
            => kind == 0;

        public static string Format(this IdentityIndicatorKind kind)
            => kind switch
             {
                IIK.PartSep => $"{IDI.PartSep}",

                IIK.SuffixSep => $"{IDI.SuffixSep}",

                IIK.SegSep => $"{IDI.SegSep}",

                IIK.Signed => $"{IDI.Signed}",

                IIK.Unsigned => $"{IDI.Unsigned}",

                IIK.Float => $"{IDI.Float}",

                IIK.Vector => $"{IDI.Vector}",

                IIK.Block => $"{IDI.Block}",

                IIK.Nat => $"{IDI.Nat}",

                IIK.Generic => $"{IDI.Generic}",

                IIK.NonGeneric => $"{IDI.NonGeneric}",

                IIK.Modifier => $"{IDI.Modifier}",

                IIK.Pointer => $"{IDI.Pointer}",

                IIK.Span => $"{IDI.Span}",

                IIK.ImSpan => $"{IDI.ImSpan}",

                IIK.NatSpan => $"{IDI.NatSpan}",

                IIK.Imm => $"{IDI.Imm}",
                _ => "unk",
            };
    }
}