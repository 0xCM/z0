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
    public readonly struct AsmCode : IFormattable<AsmCode>, IByteSpanProvider<AsmCode>
    {
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(OpIdentity.Empty, MemoryExtract.Empty);

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
        public readonly MemoryExtract Data;
        
        public MemoryAddress BaseAddress 
            => AddressRange.Start;

        /// <summary>
        /// Defines a code block for an identified operation 
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="data">The encoded data</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryExtract data)
            => new AsmCode(id, data);

        /// <summary>
        /// Defines a code block for an identified operation
        /// </summary>
        /// <param name="id">The operation identifier</param>
        /// <param name="base">The base address</param>
        /// <param name="data">The encoded bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryAddress @base, byte[] data)
            => new AsmCode(id, MemoryExtract.Define(@base,data));

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(in AsmCode src)
            => BinaryCode.Define(src.Data.Bytes);

        public ReadOnlySpan<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Data.Bytes;
        }

        public BinaryCode BinaryCode
        {
            [MethodImpl(Inline)]
            get => BinaryCode.Define(Data.Bytes);
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

        public ApiCode ApiCode
        {
            [MethodImpl(Inline)]
            get => ApiCode.Define(Id, Data.Bytes);
        }

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode Parse(OpIdentity id, string data)
            => Define(id, MemoryExtract.Define(HexParser.parsebytes(data).ToArray()));
                
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(OpIdentity id, MemoryExtract encoded)
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