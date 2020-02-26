//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Root;

    /// <summary>
    /// Defines a common set of hex formatting options
    /// </summary>
    public readonly struct HexFormatConfig : IFormatConfig
    {   
        public const string PreSpecString = "0x";             
        
        public const string PostSpecString = "h";

        public string FormatString => $"{CaseFormatChar}";

        /// <summary>
        /// Indicates whether the numeric content should be left-padded with zeros
        /// </summary>
        public readonly bool ZPad;

        /// <summary>
        /// Indicates whether a hex specifier, either prefixing or suffixing the numeric content, should be emitted
        /// </summary>
        public readonly bool Specifier;

        /// <summary>
        /// Indicates whether the hex digits 'A',..,'F' should be upper-cased
        /// </summary>
        public readonly bool Uppercase;

        /// <summary>
        /// Indicates whether the hex numeric specifier, if emitted, shold prefix the output
        /// </summary>
        public readonly bool PreSpec;

        /// <summary>
        /// The case format character, either 'X' or 'x'
        /// </summary>
        public readonly char CaseFormatChar;

        /// <summary>
        /// The character with which to intersperse hex number sequences
        /// </summary>
        public readonly char Delimiter;

        [MethodImpl(Inline)]
        public static implicit operator HexSeqFormatConfig(in HexFormatConfig src)
            => HexSeqFormatConfig.Define(src);

        [MethodImpl(Inline)]
        public static HexFormatConfig Define(bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true, char? delimiter = null)
            => new HexFormatConfig(zpad,specifier,uppercase,prespec, delimiter ?? AsciSym.Comma);
        
        [MethodImpl(Inline)]
        HexFormatConfig(bool zpad, bool specifier, bool uppercase, bool prespec, char delimiter)
        {
            this.ZPad = zpad;
            this.Specifier = specifier;
            this.Uppercase = uppercase;
            this.PreSpec = prespec;    
            this.CaseFormatChar = uppercase ? 'X' : 'x';
            this.Delimiter = delimiter;
        }
    }
}