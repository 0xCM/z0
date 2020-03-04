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
    using static CaptureTermCode;
    
    unsafe readonly struct AsmOpExtractor : IAsmOpExtractor
    {        
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmOpExtractor Create(IAsmContext context)
            => new AsmOpExtractor(context);

        [MethodImpl(Inline)]
        AsmOpExtractor(IAsmContext context)
        {
            Context = context;
        }

        public Option<CapturedData> Extract(in AsmCaptureExchange exchange, in OpIdentity id, Span<byte> src)
        {
            try
            {
                var outcome = Capture(exchange, id, ref head(src)).Outcome;            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                return CapturedData.Define(id, outcome, bytes);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<CapturedData>();
            }
        }

        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, MethodInfo src)
        {
            try
            {
                var pSrc = jit(src);
                var summary = Capture(exchange, id, pSrc);
                var outcome = summary.Outcome;            
                var captured = AsmOpExtract.Define(id, src, outcome.Range, summary.Bits, outcome.TermCode);                
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error(e);
                return AsmOpExtract.Empty;                    
            }
        }

        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
        {
            try
            {
                var pSrc = jit(src).Ptr;
                var summary = Capture(exchange, id, pSrc);
                var outcome =  summary.Outcome;   
                var captured = AsmOpExtract.Define(id, src, outcome.Range, summary.Bits, outcome.TermCode);                
                return exchange.CaptureComplete(outcome.State, captured);

            }
            catch(Exception e)
            {
                term.error(e);
                return AsmOpExtract.Empty;
            }
        }

        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, Delegate src)
        {
            try
            {
                var pSrc = jit(src);
                var summary = Capture(exchange, id, pSrc);
                var outcome = summary.Outcome;
                var captured = AsmOpExtract.Define(id, src, outcome.Range, summary.Bits, outcome.TermCode);  
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error(e);
                return AsmOpExtract.Empty;                    
            }
        }

        public AsmOpExtract Extract(in AsmCaptureExchange exchange, MethodInfo src, params Type[] args)
        {
            if(src.IsOpenGeneric())
            {
                var target = src.Reify(args);
                return Extract(in exchange, target.Identify(), target);
            }
            else
                return Extract(in exchange, src.Identify(), src);                
        }

        [MethodImpl(Inline)]
        static AsmCaptureOutcome Complete(in AsmCaptureState state, CaptureTermCode tc, long start, long end, int delta)
            => AsmCaptureOutcome.Define(state, ((ulong)start, (ulong)(end + delta)), tc);

        [MethodImpl(Inline)]
        static AsmCaptureSummary Summary(in AsmCaptureExchange exchange, in AsmCaptureState state, OpIdentity id, CaptureTermCode tc, long start, long end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var raw = exchange.Target(0, (int)(end - start)).ToArray();
            var trimmed = exchange.Target(0, outcome.ByteCount).ToArray();
            var bits = AsmCaptureBits.Define((MemoryAddress)start, raw, trimmed);
            return AsmCaptureSummary.Define(outcome, bits);
        }

        [MethodImpl(Inline)]
        AsmCaptureSummary Capture(in AsmCaptureExchange exchange, OpIdentity id, ref byte src)
            => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        AsmCaptureSummary Capture(in AsmCaptureExchange exchange, OpIdentity id, IntPtr src)        
            => capture(exchange, id, src.ToPointer<byte>());

        [MethodImpl(Inline)]
        AsmCaptureSummary capture(in AsmCaptureExchange exchange, OpIdentity id, byte* pSrc)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;            
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(AsmCaptureState);

            while(offset < limit)
            {
                state = Step(exchange, id, ref offset, ref end, ref pSrc);                                
                exchange.CaptureStep(state);                

                if(ret_offset == null && state.Payload == RET)
                    ret_offset = offset;                 

                var tc = CalcTerm(exchange, offset, ret_offset, out var delta);
                if(tc != null)         
                    return Summary(exchange, state, id, tc.Value, start, end, delta);
            }
            return Summary(exchange, state, id, CTC_BUFFER_OUT, start, end, 0);
        }                    

        [MethodImpl(Inline)]
        static AsmCaptureState Step(in AsmCaptureExchange exchange, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            exchange.Target(offset++) = code;
            location = (long)pSrc;
            return AsmCaptureState.Define(id, offset, location, code);
        }

        static CaptureTermCode? CalcTerm(in AsmCaptureExchange exchange, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = Scan4(exchange, offset, out delta);
                if(tc != null)
                    return tc;
            }

            if(offset >= 5)
            {
                var tc = Scan5(exchange, offset, out delta);
                if(tc != null)
                    return tc;
            }
                    
            if(offset >= 7 && Zx7(exchange, offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_RET_Zx7;
            }
            
            return null;
        }

        const byte ZED = 0;
        
        const byte RET = 0xc3;
        
        const byte INTR = 0xcc;
        
        const byte SBB = 0x19;
        
        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;


        [MethodImpl(Inline)]
        static CaptureTermCode? Scan4(in AsmCaptureExchange exchange, int offset, out int delta)
        {
            var x0 = exchange.Target(offset - 3);
            var x1 = exchange.Target(offset - 2);
            var x2 = exchange.Target(offset - 1);
            var x3 = exchange.Target(offset - 0);
            delta = -2;

            if(match((x0,RET), (x1, SBB)))
                return CTC_RET_SBB;
            else if(match((x0, RET), (x1, INTR)))
                return CTC_RET_INTR;
            else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                return CTC_RET_ZED_SBB;
            else if(match((x0, RET), (x1, ZED), (x2,ZED)))
                return CTC_RET_Zx3;
            else if(match((x0,INTR), (x1, INTR)))
                return CTC_INTRx2;
            else
                return null;
        }

        [MethodImpl(Inline)]
        static CaptureTermCode? Scan5(in AsmCaptureExchange exchange, int offset, out int delta)
        {
            var x0 = exchange.Target(offset - 5);
            var x1 = exchange.Target(offset - 4);
            var x2 = exchange.Target(offset - 3);
            var x3 = exchange.Target(offset - 2);
            var x4 = exchange.Target(offset - 1);
            delta = 0;
            
            if(match((x0,ZED), (x1,ZED), (x2,J48), (x3,FF), (x4,E0)))
                return CTC_JMP_RAX;
            else
                return null;
        }

        [MethodImpl(Inline)]
        static bool Zx7(in AsmCaptureExchange exchange, int offset)
            =>      exchange.Target(offset - 6) == ZED 
                && (exchange.Target(offset - 5) == ZED) 
                && (exchange.Target(offset - 4) == ZED) 
                && (exchange.Target(offset - 3) == ZED) 
                && (exchange.Target(offset - 2) == ZED) 
                && (exchange.Target(offset - 1) == ZED)                     
                && (exchange.Target(offset - 0) == ZED);

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a)
            => a.x == a.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b)
            => a.x == a.y 
            && b.x == b.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c)
            => a.x == a.y 
            && b.x == b.y 
            && c.x == c.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c, (byte x, byte y) d)
            => a.x == a.y 
            && b.x == b.y 
            && c.x == c.y 
            && d.x == d.y;

        [MethodImpl(Inline)]
        static bit match((byte x, byte y) a, (byte x, byte y) b, (byte x, byte y) c, (byte x, byte y) d, (byte x, byte y) e)
            => a.x == a.y 
            && b.x == b.y 
            && c.x == c.y 
            && d.x == d.y
            && e.x == e.y;

        /// <summary>
        /// Jits the methd and returns a pointer to the resulting method
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        static IntPtr jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        static DynamicPointer jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }        
    }
}