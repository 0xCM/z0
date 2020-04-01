//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Joins the current capture state with the state buffer to form what is effectively a cpature event data package
    /// </summary>
    public readonly ref struct AsmCaptureEvent
    {
        [MethodImpl(Inline)]
        public static AsmCaptureEvent Define(ExtractionState state, Span<byte> buffer)
            => new AsmCaptureEvent(state,buffer);        

        [MethodImpl(Inline)]
        public static AsmCaptureEvent Define(ExtractionState state, Span<byte> buffer, in CapturedOp captured)
            => new AsmCaptureEvent(state,buffer, captured);

        [MethodImpl(Inline)]
        AsmCaptureEvent(ExtractionState state, Span<byte> buffer, in CapturedOp captured)
        {
            this.EventKind = CaptureEventKind.Complete;
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.Captured = captured;
        }

        [MethodImpl(Inline)]
        AsmCaptureEvent(ExtractionState state, Span<byte> buffer)
        {
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.EventKind = CaptureEventKind.Step;
            this.Captured = Option.none<CapturedOp>();
        }

        /// <summary>
        /// The event classification
        /// </summary>
        public readonly CaptureEventKind EventKind;

        /// <summary>
        /// The capture state when the even occurred
        /// </summary>
        public readonly ExtractionState CaptureState;

        /// <summary>
        /// The state buffer
        /// </summary>
        readonly Span<byte> StateBuffer;

        /// <summary>
        /// If a completion event, the captured member
        /// </summary>
        public readonly Option<CapturedOp> Captured;

        /// <summary>
        /// Queries/Manipulates an index-identified state buffer byte
        /// </summary>
        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref refs.seek(StateBuffer, index);
        }
    }   
}