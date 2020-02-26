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
    /// Defines a line of text that contains an identifier and a sequence of bytes
    /// </summary>
    public readonly struct HexLine
    {
        public const char DefaultIdSep = AsciSym.Space;

        public const char DefaultByteSep = AsciSym.Space;

        public static FileExtension FileExt => FileExtensions.Hex;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        public static Option<HexLine> Parse(string formatted, char idsep = DefaultIdSep, char bytesep = DefaultByteSep)
        {
            try
            {
                var id = OpIdentity.Define(formatted.TakeBefore(idsep).Trim());
                var encoded = array(formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(Hex.parsebyte));
                return Define(id,encoded);                
            }
            catch(Exception e)
            {
                error(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static HexLine Define(OpIdentity id, byte[] encoded)
            => new HexLine(id,encoded);
        
        [MethodImpl(Inline)]
        public HexLine(OpIdentity id, byte[] encoded)
        {
            this.Id = id;
            this.Encoded = encoded;
        }
        
        public readonly OpIdentity Id;

        public readonly byte[] Encoded;

        public void Deconstruct(out OpIdentity id, out byte[] data)
        {
            id = Id;
            data = Encoded;
        }

        public string Format(int idpad = 0)
            => concat(Id.Identifier.PadRight(idpad), text.space(), Encoded.FormatHex());
        
        public override string ToString()
            => Format();
    }
}