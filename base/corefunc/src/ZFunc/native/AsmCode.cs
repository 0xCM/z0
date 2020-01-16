//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
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
        public readonly Moniker Id;

        /// <summary>
        /// Descriptive text
        /// </summary>
        public readonly string Label;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public readonly byte[] Data;
        
        public int Length
            => Data?.Length ?? 0;

        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(new byte[]{0}, Moniker.Empty, string.Empty);

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode Parse(string data, Moniker id)
            => new AsmCode(Hex.parsebytes(data).ToArray(), id, null);

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="id">The identity to confer</param>
        public static AsmCode<T> Parse<T>(string data, Moniker id, T t = default)
            where T : unmanaged
                => new AsmCode<T>(Hex.parsebytes(data).ToArray(),id,null);
                
        /// <summary>
        /// Loads an untyped code block from span content
        /// </summary>
        /// <param name="src">The code source</param>
        /// <param name="m">The identifying moniker</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(byte[] src, Moniker m, string label)
            => new AsmCode(src, m, label);

        /// <summary>
        /// Loads an untyped code block from span content
        /// </summary>
        /// <param name="src">The code source</param>
        /// <param name="m">The identifying moniker</param>
        [MethodImpl(Inline)]
        public static AsmCode Define(ReadOnlySpan<byte> src, Moniker m, string label)
            => new AsmCode(src.ToArray(), m, label);


        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Data;

        [MethodImpl(Inline)]
        internal AsmCode(byte[] Bytes, Moniker id, string label)
        {
            this.Data = Bytes;
            this.Id = id;
            this.Label = label ?? id;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Length == 0 ) || (Length == 1 && Data[0] == 0);
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
                
        /// <summary>
        /// Formats the encapsulated data as a sequence of comma-delimited hex bytes
        /// </summary>
        public string Format()
            => Data.AsSpan().FormatHexBytes();

        [MethodImpl(Inline)]
        public AsmCode<T> As<T>()
            where T : unmanaged
                => new AsmCode<T>(this);

        public AsmCode WithId(Moniker id)
            => new AsmCode(Data,id, Label);

        public AsmCode WithLabel(string label)
            => new AsmCode(Data, Id, label);

    }

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly struct AsmCode<T>
        where T : unmanaged
    {
        readonly AsmCode Code;

        public Moniker Id
            => Code.Id;

        public string Label
            => Code.Label;
         
        public ReadOnlySpan<byte> Data
            => Code.Data;

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
        public AsmCode(byte[] data, Moniker m, string label)
        {
            Code = new AsmCode(data,m, label);
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