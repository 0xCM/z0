
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    /// <summary>
    /// Wraps an executable non-GC'd buffer to hold assembly instruction code
    /// </summary>
    public struct NativeExecBuffer : INativeExecBuffer
    {
        public const int DefaultSize = 512;

        readonly MemoryBuffer Buffer;

        AsmCode Code;
        
        public static NativeExecBuffer Create(int? size = null)
            => new NativeExecBuffer(size ?? DefaultSize);

        NativeExecBuffer(int size)
        {
            Buffer = MemoryBuffer.Alloc(size);
            Code = AsmCode.Empty;
        }


        /// <summary>
        /// Loads the assembly code into the execution buffer
        /// </summary>
        /// <param name="code">The asm code</param>
        [MethodImpl(Inline)]
        public void Load(in AsmCode code)
        {
            Code = code;
            Buffer.Fill(code.Encoded);
        }

        [MethodImpl(Inline)]
        public BinaryOp<T> BinaryOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return Dynop.BinOp<T>(Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp<T> UnaryOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return Dynop.UnaryOp<T>(Code.Id, Buffer.Handle);

        }

        [MethodImpl(Inline)]
        public UnaryOp8 UnaryOp(N8 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp16 UnaryOp(N16 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp32 UnaryOp(N32 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp64 UnaryOp(N64 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp128 UnaryOp(N128 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public UnaryOp256 UnaryOp(N256 w, in AsmCode code)
        {
            Load(code);
            return Dynop.UnaryOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp8 BinaryOp(N8 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp16 BinaryOp(N16 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp32 BinaryOp(N32 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp64 BinaryOp(N64 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp128 BinaryOp(N128 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }

        [MethodImpl(Inline)]
        public BinaryOp256 BinaryOp(N256 w, in AsmCode code)
        {
            Load(code);
            return Dynop.BinOp(w, Code.Id, Buffer.Handle);
        }
        public void Dispose()
            => Buffer.Dispose();
    }

    

}