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
    public readonly struct EncodedHexLine : IFormattable<EncodedHexLine>
    {
        public const char DefaultIdSep = Chars.Space;

        public const char DefaultByteSep = Chars.Space;

        public static FileExtension FileExt => FileExtensions.Hex;

        public readonly OpIdentity Id;

        public readonly Addressable Encoded;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        public static Option<EncodedHexLine> Parse(string formatted)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var id = Identities.Op(formatted.TakeBefore(Chars.Space).Trim());
                var bytes = formatted.TakeAfter(Chars.Space).Split(HexSpecs.DataDelimiter, StringSplitOptions.RemoveEmptyEntries).Select(parser.ParseByte).ToArray();
                var encoded = Addressable.Define(bytes);
                return EncodedHexLine.Define(id, encoded);                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        [MethodImpl(Inline)]
        public static EncodedHexLine Define(OpIdentity id, Addressable encoded)
            => new EncodedHexLine(id, encoded);

        [MethodImpl(Inline)]
        public static EncodedHexLine Define(OpIdentity id, byte[] encoded)
            => new EncodedHexLine(id, Addressable.Define(encoded));
        
        [MethodImpl(Inline)]
        EncodedHexLine(OpIdentity id, Addressable encoded)
        {
            this.Id = id;
            this.Encoded = encoded;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out OpIdentity id, out Addressable data)
        {
            id = Id;
            data = Encoded;
        }

        public string Format()
            => string.Concat(Id.Identifier.PadRight(0), CharText.Space,  HexFormat.data(Encoded.Bytes)); 

        public string Format(int idpad)
            => string.Concat(Id.Identifier.PadRight(idpad), CharText.Space, HexFormat.data(Encoded.Bytes));

        public override string ToString()
            => Format();
    }
}