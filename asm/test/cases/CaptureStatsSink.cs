//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

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
            var s = text.factory.Builder();
            for(var i=0; i<Recognized.Length; i++)
            {
                s.Append($"{Recognized[i]}");
                if(i!=Recognized.Length - 1)
                    s.Append(", ");
            }
            return s.ToString();
        }
    }

    public delegate void OnCaptureStatsCollected();

    readonly struct CaptureStatsSink
    {                
        readonly AsmCaptureEventObserver Observer;
        
        readonly Dictionary<int,CaptureByteCode> Classified;

        public static CaptureStatsSink Create(AsmCaptureEventObserver observer)
            => new CaptureStatsSink(observer);

        CaptureStatsSink(AsmCaptureEventObserver observer)
        {
            Observer = observer;
            Classified = new Dictionary<int, CaptureByteCode>();
        }

        [MethodImpl(Inline)]
        public void Accept(in AsmCaptureEvent info)
        {
            Observer(info);
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
        static (int offset, byte value) Record(in AsmCaptureEvent data)
        {
            var offset = Offset(data);
            var value = data.CaptureState.Payload;
            data[offset] = value;
            return (offset, value);
        }

        [MethodImpl(Inline)]
        static int Offset(in AsmCaptureEvent src)        
            => src.CaptureState.Offset;        
    }

    enum CaptureByteCode : byte
    {
        ZED = 0,

        RET = 0xc3,

        INTR = 0xcc,

        SBB = 0x19,

        FF = 0xFF        
    }
}