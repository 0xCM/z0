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
        [MethodImpl(Inline)]
        public static OperationBits Define(OpUri uri, LocatedCode data)
            => new OperationBits(uri, data);

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static OperationBits Empty => Define(OpUri.Empty, LocatedCode.Empty);

        /// <summary>
        /// The source member identity
        /// </summary>
        public OpUri Uri {get;}

        /// <summary>
        /// The memory location from which the data originiated
        /// </summary>
        public readonly MemoryRange Location;

        /// <summary>
        /// The data, encoded
        /// </summary>
        public readonly LocatedCode Encoded;

        public LocatedCode Content { [MethodImpl(Inline)] get => Encoded;}        

        public MemoryAddress Address  => Location.Start;

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Content; }

        public int Length { [MethodImpl(Inline)] get => Encoded.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(OperationBits code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(in OperationBits src)
            => BinaryCode.Define(src.Encoded.Content);

        [MethodImpl(Inline)]
        public static implicit operator OperationCode(in OperationBits src)
            => OperationCode.Define(src.Uri, src.Encoded);

        [MethodImpl(Inline)]
        internal OperationBits(OpUri uri, LocatedCode encoded)
        {
            this.Uri = uri;
            this.Location = encoded.AddressRange;
            this.Encoded = encoded;
        }
        
        public string Format(int idpad)
            => string.Concat(Uri.Identifier.PadRight(idpad), CharText.Space, Encoded.Format());

        public string Format()
            => Format(0);

        public override string ToString()
            => Format();         

        public bool Equals(OperationBits src)
            => Encoded.Equals(src.Encoded);
    }
}