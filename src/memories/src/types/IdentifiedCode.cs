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
    /// Assocates an operation api identifier with executable code
    /// </summary>
    public readonly struct IdentifiedCode : IByteSpanProvider<IdentifiedCode>
    {
        public readonly BinaryCode BinaryCode;

        public readonly OpIdentity Id;

        public static IdentifiedCode Empty => new IdentifiedCode(OpIdentity.Empty, BinaryCode.Empty);
        
        /// <summary>
        /// Defines a block of encoded data based at a specifed address
        /// </summary>
        /// <param name="data">The source data</param>
        [MethodImpl(Inline)]
        public static IdentifiedCode Define(OpIdentity id, byte[] data)
            => new IdentifiedCode(id,data);        

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(IdentifiedCode src)
            => src.BinaryCode;

        [MethodImpl(Inline)]
        public IdentifiedCode(OpIdentity id, in BinaryCode data)
        {
            this.Id = id;
            this.BinaryCode = data;
        }

        public ReadOnlySpan<byte> Bytes 
        {
            [MethodImpl(Inline)]
            get => BinaryCode.Bytes;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => BinaryCode.IsEmpty && Id.IsEmpty;
        }
    }
}