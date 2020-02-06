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
    /// Joins the current capture state with the state buffer to form what
    /// is effectively a cpature event data package
    /// </summary>
    public readonly ref struct CaptureEventInfo
    {
        [MethodImpl(Inline)]
        public static CaptureEventInfo Define(CaptureState state, Span<byte> buffer)
            => new CaptureEventInfo(state,buffer);
        
        [MethodImpl(Inline)]
        CaptureEventInfo(CaptureState state, Span<byte> buffer)
        {
            this.CaptureState = state;
            this.StateBuffer = buffer;
        }

        public readonly CaptureState CaptureState;

        public readonly Span<byte> StateBuffer;
    }
}