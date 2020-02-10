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
    /// A capture event relay
    /// </summary>
    readonly struct CaptureEventRelay
    {
        readonly int[] Stats;

        readonly CaptureEventObserver Observer;
        
        public static CaptureEventRelay Create(CaptureEventObserver observer)
            => new CaptureEventRelay(observer);

        CaptureEventRelay(CaptureEventObserver observer)
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