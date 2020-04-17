//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly ref struct CaptureExchange
    {
        /// <summary>
        /// The buffer that receives the captured data
        /// </summary>
        public readonly Span<byte> TargetBuffer;

        /// <summary>
        /// A buffer tracks state meaningful to the capture workflow
        /// </summary>
        public readonly Span<byte> StateBuffer;

        /// <summary>
        /// The juncture-coincident operation set 
        /// </summary>
        public readonly ICaptureService Operations;

        /// <summary>
        /// The junction to which events will be relayed
        /// </summary>
        readonly ICaptureJunction Junction;

        [MethodImpl(Inline)]
        public static CaptureExchange Create(IMemberCaptureControl control, Span<byte> capture, Span<byte> state)
            => new CaptureExchange(control,capture,state);

        CaptureExchange(IMemberCaptureControl control, Span<byte> capture, Span<byte> state)            
        {
            require(capture.Length == state.Length);
            this.TargetBuffer = capture;
            this.StateBuffer = state;
            this.Junction = control as ICaptureJunction;
            this.Operations = control;
        }

        public void ClearBuffers()
        {
            TargetBuffer.Clear();
            StateBuffer.Clear();
        }

        /// <summary>
        /// Queries and manipulates an index-identified state buffer byte
        /// </summary>
        /// <param name="index">The cell index to query/manipulate</param>
        [MethodImpl(Inline)]
        public ref byte State(int offset)
            => ref refs.seek(StateBuffer, offset);
        
        /// <summary>
        /// Queries and manipulates an index-identified target buffer byte
        /// </summary>
        /// <param name="index">The cell index to query/manipulate</param>
        [MethodImpl(Inline)]
        public ref byte Target(int index)
            => ref refs.seek(TargetBuffer, index);

        /// <summary>
        /// Slices a section of the target buffer
        /// </summary>
        /// <param name="start">The start index</param>
        /// <param name="length">The slice length</param>
        [MethodImpl(Inline)]
        public Span<byte> Target(int start, int length)
            => TargetBuffer.Slice(start, length);

        [MethodImpl(Inline)]
        public ref readonly ApiMemberCapture CaptureComplete(in ApiExtractState state, in ApiMemberCapture captured)
        {
            Junction.OnCaptureComplete(this, state, captured);
            return ref captured;
        }

        [MethodImpl(Inline)]
        public ref readonly ApiExtractState CaptureStep(in ApiExtractState state)
        {
            Junction.OnCaptureStep(this, state);
            return ref state;
        }

        public int BufferLength 
        {
            [MethodImpl(Inline)]
            get => TargetBuffer.Length;
        }
    }
}