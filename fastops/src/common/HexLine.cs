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

        public readonly OpIdentity Id;

        public readonly EncodedData Encoded;

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
                var encoded = EncodedData.Define(array(formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(Hex.parsebyte)));
                return Define(id, encoded);                
            }
            catch(Exception e)
            {
                error(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static HexLine Define(OpIdentity id, EncodedData encoded)
            => new HexLine(id, encoded);

        [MethodImpl(Inline)]
        public static HexLine Define(OpIdentity id, byte[] encoded)
            => new HexLine(id, EncodedData.Define(encoded));
        
        [MethodImpl(Inline)]
        HexLine(OpIdentity id, EncodedData encoded)
        {
            this.Id = id;
            this.Encoded = encoded;
        }
        
        public void Deconstruct(out OpIdentity id, out EncodedData data)
        {
            id = Id;
            data = Encoded;
        }

        public string Format(int idpad = 0)
            => text.concat(Id.Identifier.PadRight(idpad), text.space(), Encoded.Bytes.FormatHex());
        
        public override string ToString()
            => Format();
    }
}