
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
    public ref struct AsmExecBuffer
    {
        public const int DefaultSize = 256;

        readonly MemoryBuffer Buffer;

        readonly long pBuffer;

        AsmCode Code;
        
        public static AsmExecBuffer Create()
            => new AsmExecBuffer(DefaultSize);

        public static AsmExecBuffer Create(int size)
            => new AsmExecBuffer(size);

        AsmExecBuffer(int size)
        {
            Buffer = MemoryBuffer.Alloc(size);
            pBuffer = (long)OS.Liberate(this.Buffer);                        
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
        public BinaryOp<T> BinOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateBinOp<T>(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public BinaryOp<T> BinOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return AsmDelegate.CreateBinOp<T>(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public UnaryOp<T> UnaryOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateUnaryOp<T>(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public UnaryOp<T> UnaryOp<T>(in AsmCode<T> code)
            where T : unmanaged
        {
            Load(code);
            return AsmDelegate.CreateUnaryOp<T>(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public UnaryOp128 UnaryOp128()
            => AsmDelegate.CreateUnaryOp128(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public UnaryOp256 UnaryOp256()
            => AsmDelegate.CreateUnaryOp256(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public BinaryOp128 BinOp128()
            => AsmDelegate.CreateBinOp128(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public BinaryOp128 BinOp128(in AsmCode code)
        {
            Load(code);
            return AsmDelegate.CreateBinOp128(pBuffer, Code.Name);
        }

        [MethodImpl(Inline)]
        public BinaryOp256 BinOp256()
            => AsmDelegate.CreateBinOp256(pBuffer, Code.Name);

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