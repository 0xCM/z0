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

    readonly struct CaptureReceiptSink : ICaptureEventSink
    {
        readonly int[] Stats;

        readonly OnCaptureReceipt Observer;
        
        public static ICaptureEventSink Create(OnCaptureReceipt observer)
            => new CaptureReceiptSink(observer);

        CaptureReceiptSink(OnCaptureReceipt observer)
        {
            this.Observer = observer;
            this.Stats = new int[1];
        }   

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventData data)
        {            
            Receive(data);
            Observer(data);
        }

        [MethodImpl(Inline)]
        public void Complete(in CaptureEventData data)
        {
            // Completion.Complete(data);
            Observer(data);
        }

        const int CountIndex = 0;


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