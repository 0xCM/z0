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

    using static Z0.Root;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly struct AsmCode : IFormattable<AsmCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(OpIdentity.Empty, MemoryEncoding.Empty);

        /// <summary>
        /// The assigned identity
        /// </summary>
        public readonly OpIdentity Id;

        /// <summary>
        /// The originating memory location
        /// </summary>
        public readonly MemoryRange AddressRange;

        /// <summary>
        /// The data, encoded
        /// </summary>
        public readonly MemoryEncoding Data;
        
        public MemoryAddress BaseAddress 
            => AddressRange.Start;

        /// <summary>
        /// Defines a code block for an identified operation 
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="data">The encoded data</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryEncoding data)
            => new AsmCode(id, data);

        /// <summary>
        /// Defines a code block for an identified operation
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="base">The base address</param>
        /// <param name="data">The encoded bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryAddress @base, byte[] data)
            => new AsmCode(id, MemoryEncoding.Define(@base,data));


        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }


        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode Parse(OpIdentity id, string data)
            => Define(id, MemoryEncoding.Define(Hex.parsebytes(data).ToArray()));
                
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        internal AsmCode(OpIdentity id, MemoryEncoding encoded)
        {
            this.Id = id;
            this.AddressRange = encoded.AddressRange;
            this.Data = encoded;
        }

        public string Format(int idpad)
            => HexLine.Define(Id, Data).Format(idpad);

        public string Format()
            => HexLine.Define(Id, Data).Format();

        public override string ToString()
            => Format();         
    }
}