//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a memory extract that is sourced from an identified operation
    /// </summary>
    public readonly struct OpExtractSegment : IFormattable<OpExtractSegment>
    {
        public const char DefaultIdSep = Chars.Space;

        public const char DefaultByteSep = Chars.Space;

        public static FileExtension FileExt => FileExtensions.Hex;

        public readonly OpIdentity Id;

        public readonly MemoryExtract Encoded;

        [MethodImpl(Inline)]
        public static OpExtractSegment Define(OpIdentity id, MemoryExtract encoded)
            => new OpExtractSegment(id, encoded);

        [MethodImpl(Inline)]
        public static OpExtractSegment Define(OpIdentity id, byte[] encoded)
            => new OpExtractSegment(id, MemoryExtract.Define(encoded));
        
        [MethodImpl(Inline)]
        OpExtractSegment(OpIdentity id, MemoryExtract encoded)
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
            => string.Concat(Id.Identifier.PadRight(0), CharText.Space, Encoded.Bytes.FormatHex());

        public string Format(int idpad)
            => string.Concat(Id.Identifier.PadRight(idpad), CharText.Space, Encoded.Bytes.FormatHex());

        public override string ToString()
            => Format();
    }
}