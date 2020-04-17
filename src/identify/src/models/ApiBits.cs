//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly struct ApiBits : IFormattable<ApiBits>, IByteSpanProvider<ApiBits>
    {
        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static ApiBits Parse(OpIdentity id, string data)
            => Define(id, Addressable.Define(HexParsers.Bytes.ParseBytes(data).ToArray()));

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static ApiBits Empty => Define(OpIdentity.Empty, Addressable.Empty);

        /// <summary>
        /// The source member identity
        /// </summary>
        public readonly OpIdentity Id;

        /// <summary>
        /// The memory location from which the data originiated
        /// </summary>
        public readonly MemoryRange Location;

        /// <summary>
        /// The data, encoded
        /// </summary>
        public readonly Addressable Encoded;
        
        public MemoryAddress BaseAddress 
            => Location.Start;

        /// <summary>
        /// Defines a code block for an identified operation 
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="data">The encoded data</param>
        [MethodImpl(Inline)]
        public static ApiBits Define(OpIdentity id, Addressable data)
            => new ApiBits(id, data);

        /// <summary>
        /// Defines a code block for an identified operation
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="base">The base address</param>
        /// <param name="data">The encoded bytes</param>
        [MethodImpl(Inline)]
        public static ApiBits Define(OpIdentity id, MemoryAddress @base, byte[] data)
            => Define(id, Addressable.Define(@base,data));

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(in ApiBits src)
            => BinaryCode.Define(src.Encoded.Bytes);

        [MethodImpl(Inline)]
        public static implicit operator IdentifiedCode(in ApiBits src)
            => IdentifiedCode.Define(src.Id, src.Encoded);

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Encoded.Bytes;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(ApiBits code)
            => code.Bytes;

        [MethodImpl(Inline)]
        ApiBits(OpIdentity id, Addressable encoded)
        {
            this.Id = id;
            this.Location = encoded.AddressRange;
            this.Encoded = encoded;
        }

        public string Format(int idpad)
            => string.Concat(Id.Identifier.PadRight(idpad), CharText.Space, HexFormat.data(Encoded.Bytes));

        public string Format()
            => Format(0);

        public override string ToString()
            => Format();         
    }
}