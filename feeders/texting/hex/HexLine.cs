//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Textual;

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