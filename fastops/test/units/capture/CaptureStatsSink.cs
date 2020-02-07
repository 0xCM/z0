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
        readonly Action<CaptureStats> OnComplete;
        
        readonly Dictionary<int,CaptureByteCode> Classified;

        public static CaptureStatsSink Create(Action<CaptureStats> completion)
            => new CaptureStatsSink(completion);

        CaptureStatsSink(Action<CaptureStats> completion)
        {
            this.OnComplete = completion;
            Classified = new Dictionary<int, CaptureByteCode>();
        }

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventInfo info)
        {
            (var offset, var value) = Record(info);
            Classify(offset,value);
        }

        public void Complete(in CapturedMember captured)
        {
            var values = Classified.Values.Select(x => x).ToArray();
            OnComplete(new CaptureStats(values));
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
        static (int offset, byte value) Record(in CaptureEventInfo info)
        {
            var offset = Offset(info);
            var value =info.CaptureState.LastValue;
            info[offset] = value;
            return (offset, value);
        }

        [MethodImpl(Inline)]
        static Span<byte> State(in CaptureEventInfo src)
            => src.StateBuffer;

        [MethodImpl(Inline)]
        static int Offset(in CaptureEventInfo src)        
            => src.CaptureState.Offset;        

        [MethodImpl(Inline)]
        static byte Value(in CaptureEventInfo src)
            => src.CaptureState.LastValue;

            
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