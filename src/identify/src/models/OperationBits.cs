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
    public readonly struct OperationBits : ILocatedCode<OperationBits,LocatedCode>
    {
        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static OperationBits Parse(OpIdentity id, string data)
            => Define(id, LocatedCode.Define(HexParsers.Bytes.ParseBytes(data).ToArray()));

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static OperationBits Empty => Define(OpIdentity.Empty, LocatedCode.Empty);

        /// <summary>
        /// The source member identity
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The memory location from which the data originiated
        /// </summary>
        public readonly MemoryRange Location;

        /// <summary>
        /// The data, encoded
        /// </summary>
        public readonly LocatedCode Encoded;

        public LocatedCode Content
        {
            [MethodImpl(Inline)]
            get => Encoded;
        }        

        public MemoryAddress Address 
            => Location.Start;

        /// <summary>
        /// Defines a code block for an identified operation 
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="data">The encoded data</param>
        [MethodImpl(Inline)]
        public static OperationBits Define(OpIdentity id, LocatedCode data)
            => new OperationBits(id, data);

        /// <summary>
        /// Defines a code block for an identified operation
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="base">The base address</param>
        /// <param name="data">The encoded bytes</param>
        [MethodImpl(Inline)]
        public static OperationBits Define(OpIdentity id, MemoryAddress @base, byte[] data)
            => Define(id, LocatedCode.Define(@base,data));

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(in OperationBits src)
            => BinaryCode.Define(src.Encoded.Content);

        [MethodImpl(Inline)]
        public static implicit operator OperationCode(in OperationBits src)
            => OperationCode.Define(src.Id, src.Encoded);

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Encoded.Content;
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
        public static implicit operator ReadOnlySpan<byte>(OperationBits code)
            => code.Bytes;

        [MethodImpl(Inline)]
        OperationBits(OpIdentity id, LocatedCode encoded)
        {
            this.Id = id;
            this.Location = encoded.AddressRange;
            this.Encoded = encoded;
        }

        public string Format(int idpad)
            => string.Concat(Id.Identifier.PadRight(idpad), CharText.Space, Encoded.Format());

        public string Format()
            => Format(0);

        public override string ToString()
            => Format();         

        public bool Equals(OperationBits src)
            => Encoded.Equals(src.Encoded);
    }
}