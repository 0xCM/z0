
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    readonly struct AsmExecBuffer : IAsmExecBuffer
    {
        public const int DefaultSize = 512;

        readonly MemoryBuffer Buffer;

        public IAsmContext Context {get;}
        
        [MethodImpl(Inline)]
        public static AsmExecBuffer Create(IAsmContext context, int? size = null)
            => new AsmExecBuffer(context, size ?? DefaultSize);

        [MethodImpl(Inline)]
        AsmExecBuffer(IAsmContext context, int size)
        {
            Context = context;
            Buffer = MemoryBuffer.Alloc(size);
        }

        /// <summary>
        /// Loads the assembly code into the execution buffer
        /// </summary>
        /// <param name="src">The asm code</param>
        [MethodImpl(Inline)]
        public IntPtr Load(in AsmCode src)
        {
            Buffer.Fill(src.Encoded);
            return Buffer.Handle;
        }
 
         [MethodImpl(Inline)]
         public FixedFunc<X0,R> F<X0,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed             
                => Dynop.Func<X0,R>(src.Id, Load(src));                                

         [MethodImpl(Inline)]
         public FixedFunc<X0,X1,R> F<X0,X1,R>(in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => Dynop.Func<X0,X1,R>(src.Id, Load(src));                
        
         [MethodImpl(Inline)]
         public FixedFunc<T,T> UnaryOp<T>(in AsmCode src)
            where T : unmanaged, IFixed
                => F<T,T>(src);

         [MethodImpl(Inline)]
         public FixedFunc<T,T,T> BinaryOp<T>(in AsmCode src)
            where T : unmanaged, IFixed
                => F<T,T,T>(src);

        public void Dispose()
            => Buffer.Dispose();
    }
}