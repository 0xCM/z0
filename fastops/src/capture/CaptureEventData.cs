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

    /// <summary>
    /// Joins the current capture state with the state buffer to form what is effectively a cpature event data package
    /// </summary>
    public readonly ref struct CaptureEventData
    {
        [MethodImpl(Inline)]
        public static CaptureEventData Define(CaptureState state, Span<byte> buffer)
            => new CaptureEventData(state,buffer);        

        [MethodImpl(Inline)]
        public static CaptureEventData Define(CaptureState state, Span<byte> buffer, in CapturedMember captured)
            => new CaptureEventData(state,buffer, captured);

        [MethodImpl(Inline)]
        CaptureEventData(CaptureState state, Span<byte> buffer, in CapturedMember captured)
        {
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.Captured = captured;
        }

        [MethodImpl(Inline)]
        CaptureEventData(CaptureState state, Span<byte> buffer)
        {
            this.CaptureState = state;
            this.StateBuffer = buffer;
            this.Captured = none<CapturedMember>();
        }

        /// <summary>
        /// The capture state when the even occurred
        /// </summary>
        public readonly CaptureState CaptureState;

        /// <summary>
        /// The state buffer
        /// </summary>
        public readonly Span<byte> StateBuffer;

        /// <summary>
        /// If a completion event, the captured member
        /// </summary>
        public readonly Option<CapturedMember> Captured;

        /// <summary>
        /// Queries/Manipulates an index-identified state buffer byte
        /// </summary>
        public ref byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(StateBuffer, index);
        }
    }
   
}