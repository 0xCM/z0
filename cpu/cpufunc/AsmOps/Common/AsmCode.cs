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
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Globalization;

    using static zfunc;

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly ref struct AsmCode
    {
        /// <summary>
        /// The name given to the code block
        /// </summary>
        public readonly Moniker Name;

        /// <summary>
        /// The encoded asm bytes
        /// </summary>
        public readonly ReadOnlySpan<byte> Data;
        
        /// <summary>
        /// The canonical zero
        /// </summary>
        public static AsmCode Empty => new AsmCode(new byte[]{0}, Moniker.Empty);

        /// <summary>
        /// Materializes an untyped assembly code block from comma-delimited hex-encoded bytes
        /// </summary>
        /// <param name="data">The encoded assembly</param>
        /// <param name="moniker">The identity to confer</param>
        public static AsmCode Parse(string data, Moniker moniker)
            => new AsmCode(Hex.parsebytes(data).ToArray(),moniker);

        /// <summary>
        /// Materializes an untyped code block from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        public static AsmCode Read(FolderName subfolder, Moniker m)
            => AsmCode.Parse(Paths.AsmHexPath(subfolder, m).ReadText(),m);

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="subfolder">The asm log subfolder to search</param>
        /// <param name="match">The match predicate</param>
        public static IEnumerable<FilePath> Files(FolderName subfolder, string match)        
            => Paths.AsmDataDir(subfolder).Files(Paths.AsmHexExt, match);

        /// <summary>
        /// Loads an untyped code block from span content
        /// </summary>
        /// <param name="src">The code source</param>
        /// <param name="m">The identifying moniker</param>
        [MethodImpl(Inline)]
        public static AsmCode Load(ReadOnlySpan<byte> src, Moniker m)
            => new AsmCode(src, m);

        /// <summary>
        /// Loads a typed code block from span content
        /// </summary>
        /// <param name="src">The code source</param>
        /// <param name="opcode">The identity to confer</param>
        [MethodImpl(Inline)]
        public static AsmCode<T> Load<T>(ReadOnlySpan<byte> src)
            where T:unmanaged
                => new AsmCode<T>(src, Moniker.Empty);        

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode code)
            => code.Data;

        [MethodImpl(Inline)]
        internal AsmCode(ReadOnlySpan<byte> Bytes, Moniker name)
        {
            this.Data = Bytes;
            this.Name = name;
        }

        /// <summary>
        /// Returns a pointer to the endoded bytes
        /// </summary>
        public readonly IntPtr Pointer
        {
            [MethodImpl(Inline)]
            get => GetPointer();
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Length == 1 && Data[0] == 0;
        }
        
        /// <summary>
        /// Creates a delegate to execute the encapsulated code
        /// </summary>
        /// <typeparam name="T">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public T CreateDelegate<T>()
            where T : Delegate        
                => Marshal.GetDelegateForFunctionPointer<T>(Pointer);

        public string Format()
            => Data.FormatHexBytes();

        [MethodImpl(Inline)]
        unsafe IntPtr GetPointer()        
            => (IntPtr)Unsafe.AsPointer(ref mutable(in head(Data)));
    }

    /// <summary>
    /// Encapsulates a block of encoded assembly
    /// </summary>
    public readonly ref struct AsmCode<T>
        where T : unmanaged
    {
        readonly AsmCode Untyped;

        public Moniker Name
            => Untyped.Name;

        public ReadOnlySpan<byte> Data
            => Untyped.Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmCode(AsmCode<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsmCode<T> src)
            => src.Data;
        
        [MethodImpl(Inline)]
        public AsmCode(AsmCode src)
        {
            this.Untyped = src;
        }

        [MethodImpl(Inline)]
        public AsmCode(ReadOnlySpan<byte> data, Moniker m)
        {
            Untyped = new AsmCode(data,m);
        }

        /// <summary>
        /// Returns a pointer to the endoded bytes
        /// </summary>
        public readonly IntPtr Pointer
        {
            [MethodImpl(Inline)]
            get => Untyped.Pointer;
        }

        /// <summary>
        /// Specifies whether to block is emtpy
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Untyped.IsEmpty;
        }

        /// <summary>
        /// Creates a delegate to execute the encapsulated code
        /// </summary>
        /// <typeparam name="T">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public S CreateDelegate<S>()
            where S : Delegate        
                => Untyped.CreateDelegate<S>();

        [MethodImpl(Inline)]
        public AsmCode<S> As<S>()
            where S : unmanaged
                => new AsmCode<S>(Untyped);
    
        public string Format()
            => Untyped.Format();
    }
}