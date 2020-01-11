
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
    public struct AsmExecBuffer : IDisposable
    {
        public const int DefaultSize = 512;

        readonly MemoryBuffer Buffer;

        readonly long pBuffer;

        AsmCode Code;
        
        public static AsmExecBuffer Create(int? size = null)
            => new AsmExecBuffer(size ?? DefaultSize);

        AsmExecBuffer(int size)
        {
            Buffer = MemoryBuffer.Alloc(size);
            pBuffer = (long)Buffer.Handle;
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
            Buffer.Fill(code.Data);
        }

        [MethodImpl(Inline)]
        public BinaryOp<T> BinOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return AsmDelegate.CreateBinOp<T>(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public UnaryOp<T> UnaryOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return AsmDelegate.CreateUnaryOp<T>(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp8 BinOp8(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp8(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp16 BinOp16(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp16(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp32 BinOp32(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp32(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp64 BinOp64(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp64(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp128 BinOp128(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp128(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp256 BinOp256(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp256(pBuffer, Code.Name);
        }

        public void Dispose()
            => Buffer.Dispose();
    }
}