//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly struct AsmCode
    {
        /// <summary>
        /// The assigned identity
        /// </summary>
        public readonly OpIdentity Id;

        /// <summary>
        /// The originating memory location
        /// </summary>
        public readonly MemoryRange AddressRange;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public readonly byte[] Encoded;
        
        public int Length
            => Encoded?.Length ?? 0;

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(OpIdentity.Empty, MemoryRange.Empty, new byte[]{0});

        /// <summary>
        /// Defines a fully-specified code block
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        /// <param name="src">The originating memory location</param>
        /// <param name="label">Descriptive text</param>
        /// <param name="data">The code bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryRange src, byte[] data)
            => new AsmCode(id, src, data);

        /// <summary>
        /// Defines a minimally-specified code block
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        /// <param name="data">The code bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, byte[] data)
            => new AsmCode(id, MemoryRange.Empty, data);

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode Parse(OpIdentity id, string data)
            => new AsmCode(id, MemoryRange.Empty, Hex.parsebytes(data).ToArray());
                
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Encoded;

        [MethodImpl(Inline)]
        internal AsmCode(OpIdentity id, MemoryRange src, byte[] encoded)
        {
            this.Id = id;
            this.AddressRange = src;
            this.Encoded = encoded;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Encoded[0] == 0);
        }
                
        public string Format(int idpad = 0)
            => HexLine.Define(Id, Encoded).Format(idpad);

        public override string ToString()
            => Format();         
    }
}