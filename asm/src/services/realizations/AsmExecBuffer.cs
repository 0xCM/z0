
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
    public readonly struct AsmExecBuffer : IAsmExecBuffer
    {
        public const int DefaultSize = 512;

        readonly IMemoryBuffer Buffer;

        public IAsmContext Context {get;}
        
        public static IAsmExecBuffer Create(int? size = null)
            => new AsmExecBuffer(null, size);

        public static IAsmExecBuffer Create(IAsmContext context, int? size = null)
            => new AsmExecBuffer(context, size);

        public IntPtr Handle
        {
            [MethodImpl(Inline)]
            get => Buffer.Handle;
        }

        AsmExecBuffer(IAsmContext context, int? size = null)
        {
            Context = context;
            Buffer = MemoryBuffer.Alloc(size ?? DefaultSize);
        }

        /// <summary>
        /// Loads the assembly code into the execution buffer
        /// </summary>
        /// <param name="src">The asm code</param>
        [MethodImpl(Inline)]
        public IntPtr Load(in AsmCode src)
        {
            Buffer.Fill(src.Encoded);
            return Handle;
        }

        public void Dispose()
            => Buffer.Dispose();
    }
}