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

    public static class FixedAsm
    {
        public static FixedAsm<T> Define<T>(AsmCode code)
            where T : unmanaged, IFixed
                => new FixedAsm<T>(code);

        public static FixedAsm<T> Parse<T>(OpIdentity id, string data)
            where T : unmanaged, IFixed
            => Define<T>(AsmCode.Parse(id,data));

    }

    public readonly struct FixedAsm<T>
        where T : unmanaged, IFixed
    {

        internal FixedAsm(in AsmCode code)
        {
            this.Code = code;
        }

        public readonly AsmCode Code;        

        /// <summary>
        /// The identifying moniker
        /// </summary>
        public OpIdentity Id
            => Code.Id;

        /// <summary>
        /// The originating memory location
        /// </summary>
        public MemoryRange Origin
            => Code.Origin;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public byte[] Encoded
        {
            [MethodImpl(Inline)]
            get => Code.Encoded;
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Code.Length;
        }

        public string Format(int idpad = 0)
            => Code.Format(idpad);

        public override string ToString()
            => Format();
    }

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
        public readonly MemoryRange Origin;

        /// <summary>
        /// Descriptive text
        /// </summary>
        public readonly string Label;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public readonly byte[] Encoded;
        
        public int Length
            => Encoded?.Length ?? 0;

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(OpIdentity.Empty, MemoryRange.Empty, string.Empty,  new byte[]{0});

        /// <summary>
        /// Defines a fully-specified code block
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        /// <param name="origin">The originating memory location</param>
        /// <param name="label">Descriptive text</param>
        /// <param name="data">The code bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, MemoryRange origin, string label, byte[] data)
            => new AsmCode(id, origin, label, data);

        /// <summary>
        /// Defines a minimally-specified code block
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        /// <param name="data">The code bytes</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(OpIdentity id, byte[] data)
            => new AsmCode(id, MemoryRange.Empty, id, data);

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode Parse(OpIdentity id, string data)
            => Define(id, Hex.parsebytes(data).ToArray());

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode<T> Parse<T>(string data, OpIdentity id, T t = default)
            where T : unmanaged
                => new AsmCode<T>(id, MemoryRange.Empty, id.Identifier, Hex.parsebytes(data).ToArray());
                
        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Encoded;

        [MethodImpl(Inline)]
        internal AsmCode(OpIdentity id, MemoryRange origin,  string label, byte[] encoded)
        {
            this.Id = id;
            this.Origin = origin;
            this.Label = label;
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
            => AsmHexLine.Define(Id,Encoded).Format(idpad);

        public override string ToString()
            => Format();
         
        [MethodImpl(Inline)]
        public AsmCode<T> As<T>()
            where T : unmanaged
                => new AsmCode<T>(this);

        [MethodImpl(Inline)]
        public FixedAsm<T> AsFixed<T>()
            where T : unmanaged, IFixed
                => FixedAsm.Define<T>(this);

        [MethodImpl(Inline)]
        public AsmCode WithIdentity(OpIdentity id)
            => Define(id, Origin, Label, Encoded);
    }

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly struct AsmCode<T>
        where T : unmanaged
    {
        readonly AsmCode Code;

        public OpIdentity Id
            => Code.Id;

        public MemoryRange Origin
            => Code.Origin;

        public string Label
            => Code.Label;
         
        public ReadOnlySpan<byte> Data
            => Code.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator AsmCode(AsmCode<T> src)
            => src.Code;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode<T> src)
            => src.Data;
        
        [MethodImpl(Inline)]
        public AsmCode(AsmCode src)
        {
            this.Code = src;
        }

        [MethodImpl(Inline)]
        public AsmCode(OpIdentity id, MemoryRange origin, string label, byte[] data)
        {
            Code = new AsmCode(id, origin,label,data);
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Code.IsEmpty;
        }

        [MethodImpl(Inline)]
        public AsmCode<S> As<S>()
            where S : unmanaged
                => new AsmCode<S>(Code);
    
        public AsmCode Untyped  
        {
            [MethodImpl(Inline)]
            get => Code;
        }

        public string Format()
            => Code.Format();
    }
}