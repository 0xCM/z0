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

        public static CaptureExchange Define(Span<byte> capture)
            => new CaptureExchange(EmptyJunction.Empty, capture, capture.Replicate());

        CaptureExchange(ICaptureJunction juntion, Span<byte> capture, Span<byte> state)            
        {
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

        [MethodImpl(Inline)]
        public void Complete(in CapturedMember captured)
            => Junction.Complete(captured, this);

        [MethodImpl(Inline)]
        public void Accept(in CaptureState state)
            => Junction.Accept(state, this);

        readonly struct EmptyJunction : ICaptureJunction
        {
            public static EmptyJunction Empty => default;
                    
            public void Accept(in CaptureState state, in CaptureExchange exchange){}

            public void Complete(in CapturedMember captured, in CaptureExchange exchange) {}
        }
    }
}