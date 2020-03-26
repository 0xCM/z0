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

    using static Root;

    /// <summary>
    /// Defines a line of text that contains an identifier and a sequence of bytes
    /// </summary>
    public readonly struct HexLine : IFormattable<HexLine>
    {
        public const char DefaultIdSep = AsciSym.Space;

        public const char DefaultByteSep = AsciSym.Space;

        public static FileExtension FileExt => FileExtensions.Hex;

        public readonly OpIdentity Id;

        public readonly MemoryExtract Encoded;

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
                var id = Identify.Op(formatted.TakeBefore(idsep).Trim());
                var bytes = formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(Hex.parsebyte).ToArray();
                var encoded = MemoryExtract.Define(bytes);
                return Define(id, encoded);                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static HexLine Define(OpIdentity id, MemoryExtract encoded)
            => new HexLine(id, encoded);

        [MethodImpl(Inline)]
        public static HexLine Define(OpIdentity id, byte[] encoded)
            => new HexLine(id, MemoryExtract.Define(encoded));
        
        [MethodImpl(Inline)]
        HexLine(OpIdentity id, MemoryExtract encoded)
        {
            this.Id = id;
            this.Encoded = encoded;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out OpIdentity id, out MemoryExtract data)
        {
            id = Id;
            data = Encoded;
        }

        public string Format()
            => text.concat(Id.Identifier.PadRight(0), text.space(), Encoded.Bytes.FormatHex());

        public string Format(int idpad)
            => text.concat(Id.Identifier.PadRight(idpad), text.space(), Encoded.Bytes.FormatHex());

        public override string ToString()
            => Format();
    }
}