//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Joins the current capture state with the state buffer to form what is effectively a cpature event data package
    /// </summary>
    public readonly ref struct AsmCaptureEvent
    {
        [MethodImpl(Inline)]
        public static AsmCaptureEvent Define(AsmCaptureState state, Span<byte> buffer)
            => new AsmCaptureEvent(state,buffer);        

        [MethodImpl(Inline)]
        public static AsmCaptureEvent Define(AsmCaptureState state, Span<byte> buffer, in AsmOpExtract captured)
            => new AsmCaptureEvent(state,buffer, captured);

        [MethodImpl(Inline)]
        AsmCaptureEvent(AsmCaptureState state, Span<byte> buffer, in AsmOpExtract captured)
        {
            this.EventKind = CaptureEventKind.Complete;
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.Captured = captured;
        }

        [MethodImpl(Inline)]
        AsmCaptureEvent(AsmCaptureState state, Span<byte> buffer)
        {
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.EventKind = CaptureEventKind.Step;
            this.Captured = none<AsmOpExtract>();
        }

        /// <summary>
        /// The event classification
        /// </summary>
        public readonly CaptureEventKind EventKind;

        /// <summary>
        /// The capture state when the even occurred
        /// </summary>
        public readonly AsmCaptureState CaptureState;

        /// <summary>
        /// The state buffer
        /// </summary>
        readonly Span<byte> StateBuffer;

        /// <summary>
        /// If a completion event, the captured member
        /// </summary>
        public readonly Option<AsmOpExtract> Captured;

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