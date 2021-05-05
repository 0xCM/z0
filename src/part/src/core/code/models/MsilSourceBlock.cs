//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MsilSourceBlock : ISourceCode<MsilSourceBlock,byte>
    {
        /// <summary>
        /// The source method token
        /// </summary>
        public CliToken Id {get;}

        /// <summary>
        /// The source method signature
        /// </summary>
        public CliSig Sig {get;}

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public MsilSourceBlock(CliToken id, CliSig sig, BinaryCode encoded)
        {
            Id = id;
            Sig = sig;
            Encoded = encoded;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Encoded.Size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Id.IsEmpty && Sig.IsEmpty && Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Id.IsNonEmpty || Sig.IsNonEmpty || Encoded.IsNonEmpty;
        }

        public bool Complete
        {
            [MethodImpl(Inline)]
            get => Id.IsNonEmpty && Sig.IsNonEmpty && Encoded.IsNonEmpty;
        }

        public static MsilSourceBlock Empty
        {
            [MethodImpl(Inline)]
            get => new MsilSourceBlock(CliToken.Empty, CliSig.Empty, BinaryCode.Empty);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Encoded.View;
        }
    }
}