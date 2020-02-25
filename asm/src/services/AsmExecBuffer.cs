
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
    readonly struct AsmExecBuffer : IAsmExecBuffer
    {
        public const int DefaultSize = 512;

        public IAsmContext Context {get;}

        public BufferToken Token {get;}
        
        public IntPtr Handle {get;}

        public int Length {get;}

        [MethodImpl(Inline)]
        public static IAsmExecBuffer Create(IAsmContext context, int? size = null)
            => new AsmExecBuffer(context, size);

        [MethodImpl(Inline)]
        AsmExecBuffer(IAsmContext context, int? size = null)
        {
            Context = context;            
            var buffer = ExecBuffers.alloc(size ?? DefaultSize);
            Handle = buffer.Handle;
            Length = buffer.Length;
            Token = buffer;
        }

        [MethodImpl(Inline)]
        public void Dispose()
            => ExecBuffer.Own(Token).Dispose();
    }
}