//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a memory extract that is sourced from an identified operation
    /// </summary>
    public readonly struct AsmHexLine : IFormattable<AsmHexLine>
    {
        public const char DefaultIdSep = Chars.Space;

        public const char DefaultByteSep = Chars.Space;

        public static FileExtension FileExt => FileExtensions.Hex;

        public readonly OpIdentity Id;

        public readonly MemoryExtract Encoded;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        public static Option<AsmHexLine> Parse(string formatted, char idsep = AsmHexLine.DefaultIdSep, char bytesep = AsmHexLine.DefaultByteSep)
        {
            try
            {
                var parser = HexParser.ByteParser;
                var id = Identify.Op(formatted.TakeBefore(idsep).Trim());
                var bytes = formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(parser.ParseByte).ToArray();
                var encoded = MemoryExtract.Define(bytes);
                return AsmHexLine.Define(id, encoded);                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static AsmHexLine Define(OpIdentity id, MemoryExtract encoded)
            => new AsmHexLine(id, encoded);

        [MethodImpl(Inline)]
        public static AsmHexLine Define(OpIdentity id, byte[] encoded)
            => new AsmHexLine(id, MemoryExtract.Define(encoded));
        
        [MethodImpl(Inline)]
        AsmHexLine(OpIdentity id, MemoryExtract encoded)
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
            => string.Concat(Id.Identifier.PadRight(0), CharText.Space, Encoded.Bytes.FormatHexBytes(Chars.Space,true));

        public string Format(int idpad)
            => string.Concat(Id.Identifier.PadRight(idpad), CharText.Space, Encoded.Bytes.FormatHexBytes(Chars.Space,true,true));

        public override string ToString()
            => Format();
    }
}