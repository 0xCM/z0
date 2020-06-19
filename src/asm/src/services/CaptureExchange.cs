//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly ref struct CaptureExchange
    {
        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        readonly Span<byte> TargetBuffer;

        /// <summary>
        /// The juncture-coincident operation set 
        /// </summary>
        public readonly ICaptureCore Service;

        /// <summary>
        /// Allocatates buffers and creates an exchange over the allocation
        /// </summary>
        /// <param name="context">The source context</param>
        public static CaptureExchange Create(IAsmContext context)    
            => new CaptureExchange(context.CaptureCore, new byte[context.DefaultBufferLength]);
                
        /// <summary>
        /// Allocatates buffers and creates an exchange over the allocation
        /// </summary>
        /// <param name="context">The source context</param>
        public static CaptureExchange Create(ICaptureCore service, int size = Pow2.T14)
            => new CaptureExchange(service, new byte[size]);

        [MethodImpl(Inline)]
        public static CaptureExchange Create(ICaptureCore service, Span<byte> capture, Span<byte> state = default)
            => new CaptureExchange(service, capture);

        internal CaptureExchange(ICaptureCore service, Span<byte> capture)            
        {
            TargetBuffer = capture;
            Service = service;
        }
        
        /// <summary>
        /// Queries and manipulates an index-identified target buffer byte
        /// </summary>
        /// <param name="index">The cell index to query/manipulate</param>
        [MethodImpl(Inline)]
        public ref byte Target(int index)
            => ref refs.seek(TargetBuffer, index);

        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Target(index);
        }

        /// <summary>
        /// Slices a section of the target buffer
        /// </summary>
        /// <param name="start">The start index</param>
        /// <param name="length">The slice length</param>
        [MethodImpl(Inline)]
        public Span<byte> Target(int start, int length)
            => TargetBuffer.Slice(start, length);

        [MethodImpl(Inline)]
        public ref readonly CapturedCode CaptureComplete(in ExtractState state, in CapturedCode captured)
            => ref captured;

        [MethodImpl(Inline)]
        public ref readonly ExtractState CaptureStep(in ExtractState state)
            => ref state;

        public int BufferLength 
        {
            [MethodImpl(Inline)]
            get => TargetBuffer.Length;
        }
    }
}