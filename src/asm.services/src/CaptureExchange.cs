//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        [MethodImpl(Inline)]
        public CaptureExchange(ICaptureCore service, Span<byte> capture)
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
            => ref Root.seek(TargetBuffer, index);

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
        public ref readonly ApiCapture CaptureComplete(in ExtractState state, in ApiCapture captured)
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