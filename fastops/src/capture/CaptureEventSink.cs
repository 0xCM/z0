//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    readonly struct CaptureEventSink : ICaptureEventSink
    {
        readonly int[] Stats;

        readonly CaptureEventObserver Observer;
        
        public static ICaptureEventSink Create(CaptureEventObserver observer)
            => new CaptureEventSink(observer);

        CaptureEventSink(CaptureEventObserver observer)
        {
            this.Observer = observer;
            this.Stats = new int[1];
        }   

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventData data)
        {            
            if(data.EventKind != CaptureEventKind.Complete)
            {
                Stats[CountIndex]++;
                data[Offset(data)] = data.CaptureState.Payload;
            }

            Observer(data);
        }

        const int CountIndex = 0;

        [MethodImpl(Inline)]
        static int Offset(in CaptureEventData src)        
            => src.CaptureState.Offset;        
    }
}