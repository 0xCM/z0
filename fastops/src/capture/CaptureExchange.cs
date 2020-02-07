//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

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

        readonly ICaptureJunction Junction;

        public static CaptureExchange Define(ICaptureJunction junction, Span<byte> capture, Span<byte> state)
            => new CaptureExchange(junction,capture,state);

        CaptureExchange(ICaptureJunction juntion, Span<byte> capture, Span<byte> state)            
        {
            require(capture.Length == state.Length);
            this.TargetBuffer = capture;
            this.StateBuffer = state;
            this.Junction = juntion;
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
            => ref seek(StateBuffer, offset);
        
        /// <summary>
        /// Queries and manipulates an index-identified target buffer byte
        /// </summary>
        /// <param name="index">The cell index to query/manipulate</param>
        [MethodImpl(Inline)]
        public ref byte Target(int index)
            => ref seek(TargetBuffer, index);

        /// <summary>
        /// Slices a seection of the target buffer
        /// </summary>
        /// <param name="start">The start index</param>
        /// <param name="length">The slice length</param>
        [MethodImpl(Inline)]
        public Span<byte> Target(int start, int length)
            => TargetBuffer.Slice(start, length);

        [MethodImpl(Inline)]
        public ref readonly CapturedMember Complete(in CapturedMember captured)
        {
            Junction.Complete(this, captured);
            return ref captured;
        }

        [MethodImpl(Inline)]
        public ref readonly CaptureState Accept(in CaptureState state)
        {
            Junction.Accept(this, state);
            return ref state;
        }

        public int BufferLength 
        {
            [MethodImpl(Inline)]
            get => TargetBuffer.Length;
        }

        readonly struct EmptyJunction : ICaptureJunction
        {
            public static EmptyJunction Empty => default;
                    
            public void Accept(in CaptureExchange exchange, in CaptureState state){}

            public void Complete(in CaptureExchange exchange, in CapturedMember captured) {}
        }
    }
}