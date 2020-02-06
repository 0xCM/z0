//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a line of text that contains an identifier and a sequence encoded assembly bytes
    /// </summary>
    public readonly struct AsmHexLine
    {
        public const char DefaultIdSep = AsciSym.Space;

        public const char DefaultByteSep = AsciSym.Space;

        public static FileExtension FileExt => Paths.HexExt;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        public static Option<AsmHexLine> Parse(string formatted, char idsep = DefaultIdSep, char bytesep = DefaultByteSep)
        {
            try
            {
                var id = OpIdentity.Define(formatted.TakeBefore(idsep).Trim());
                var encoded = array(formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(Hex.parsebyte));
                return Define(id,encoded);                
            }
            catch(Exception e)
            {
                errout(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static AsmHexLine Define(OpIdentity id, byte[] encoded)
            => new AsmHexLine(id,encoded);
        
        [MethodImpl(Inline)]
        public AsmHexLine(OpIdentity id, byte[] encoded)
        {
            this.Id = id;
            this.Encoded = encoded;
        }
        
        public readonly OpIdentity Id;

        public readonly byte[] Encoded;

        public string Format(int idpad = 0)
            => concat(Id.Identifier.PadRight(idpad), space(), Encoded.FormatAsmHex());
        
        public override string ToString()
            => Format();

    }

}