//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// The default implementation of the state buffer client
    /// </summary>
    readonly struct CaptureStateSink : ICaptureEventSink
    {
        readonly int[] Stats;

        readonly ICaptureEventSink Observer;
        
        public static CaptureStateSink Create(ICaptureEventSink observer)
            => new CaptureStateSink(observer);

        CaptureStateSink(ICaptureEventSink observer)
        {
            this.Observer = observer;
            this.Stats = new int[1];
        }   

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventData info)
        {            
            Receive(info);
        }

        [MethodImpl(Inline)]
        public void Complete(in CaptureEventData data)
        {
            // Completion.Complete(data);
        }

        const int CountIndex = 0;

        [MethodImpl(Inline)]
        static Span<byte> State(in CaptureEventData src)
            => src.StateBuffer;

        [MethodImpl(Inline)]
        static int Offset(in CaptureEventData src)        
            => src.CaptureState.Offset;        

        [MethodImpl(Inline)]
        (int offset, byte value) Receive(in CaptureEventData info)
        {
            Stats[CountIndex]++;
            var offset = Offset(info);
            var value = info.CaptureState.Payload;
            info[offset] = value;
            return (offset, value);
        }
    }


}