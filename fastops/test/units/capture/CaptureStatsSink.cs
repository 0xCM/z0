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
    using Z0;

    readonly struct CaptureStats
    {
        [MethodImpl(Inline)]
        public CaptureStats(CaptureByteCode[] recognized)
        {
            this.Recognized = recognized;
        }
        
        public readonly CaptureByteCode[] Recognized;

        public override string ToString()
        {
            var s = text();
            for(var i=0; i<Recognized.Length; i++)
            {
                s.Append($"{Recognized[i]}");
                if(i!=Recognized.Length - 1)
                    s.Append(", ");
            }
            return s.ToString();
        }
    }

    readonly struct CaptureStatsSink : ICaptureEventSink
    {                
        readonly Action<CaptureState> Observer;
        
        readonly Dictionary<int,CaptureByteCode> Classified;

        public static CaptureStatsSink Create(Action<CaptureState> observer)
            => new CaptureStatsSink(observer);

        CaptureStatsSink(Action<CaptureState> observer)
        {
            Observer = observer;
            Classified = new Dictionary<int, CaptureByteCode>();
        }

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventData info)
        {
            Observer(info.CaptureState);
            (var offset, var value) = Record(info);
            Classify(offset,value);
        }


        [MethodImpl(Inline)]
        void Classify(int offset, byte value)
        {
            var kind = GetKind(offset,value);
            if(kind.HasValue)
                Classified[offset] = kind.Value;            
        }

        static CaptureByteCode? GetKind(int offset, byte value)
        {
            switch((CaptureByteCode)value)
            {
                case CaptureByteCode.ZED:
                    return CaptureByteCode.ZED;
                case CaptureByteCode.RET:
                    return CaptureByteCode.RET;
                case CaptureByteCode.SBB:
                    return CaptureByteCode.SBB;
                case CaptureByteCode.INTR:
                    return CaptureByteCode.INTR;
                case CaptureByteCode.FF:
                    return CaptureByteCode.FF;                
            }
            return null;
        }
        
        [MethodImpl(Inline)]
        static (int offset, byte value) Record(in CaptureEventData data)
        {
            var offset = Offset(data);
            var value =data.CaptureState.Payload;
            data[offset] = value;
            return (offset, value);
        }

        [MethodImpl(Inline)]
        static int Offset(in CaptureEventData src)        
            => src.CaptureState.Offset;        

        public void Complete(in CaptureEventData data)
        {
            Observer(data.CaptureState);
            
        }
    }

    enum CaptureByteCode : byte
    {
        ZED = 0,

        RET = 0xc3,

        INTR = 0xcc,

        SBB = 0x19,

        FF = 0xFF        
    }

    static class CaptureStatsX
    {

    }

}