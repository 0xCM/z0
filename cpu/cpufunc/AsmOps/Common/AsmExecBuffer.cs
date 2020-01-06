
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
        public const int MinSize = 256;

        readonly MemoryBuffer Buffer;

        readonly long pBuffer;

        AsmCode Code;
        
        public static AsmExecBuffer Create(int? size = null)
            => new AsmExecBuffer(size ?? MinSize);

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
        public void Load(AsmCode code)
        {
            Code = code;
            Buffer.Fill(code.Data);
        }


        /// <summary>
        /// Loads the assembly code into the execution buffer
        /// </summary>
        /// <param name="code">The asm code</param>
        [MethodImpl(Inline)]
        public void Load(ReadOnlySpan<byte> data, Moniker m)
        {
            Load(AsmCode.Load(data,m));            
        }

        [MethodImpl(Inline)]
        public BinaryOp<T> BinOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateBinOp<T>(pBuffer, Code.Name);

        [MethodImpl(Inline)]
        public UnaryOp<T> UnaryOp<T>()
            where T : unmanaged
                => AsmDelegate.CreateUnaryOp<T>(pBuffer, Code.Name);

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
        public BinaryOp256 BinOp256()
            => AsmDelegate.CreateBinOp256(pBuffer, Code.Name);



        public void Dispose()
            => Buffer.Dispose();
    }
}