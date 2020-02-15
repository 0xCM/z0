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
    
    using static CaptureTermCode;
    using static CaptureHelpers;

    unsafe readonly struct CaptureOps : ICaptureOps
    {
        public Option<CapturedData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src)
        {
            try
            {
                var outcome = Capture(exchange, id, ref head(src)).Outcome;            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                return CapturedData.Define(id, outcome, bytes);
            }
            catch(Exception e)
            {
                errout(e);
                return none<CapturedData>();
            }
        }

        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src)
        {
            try
            {
                var pSrc = jit(src);
                var summary = Capture(exchange, id, pSrc);
                var outcome = summary.Outcome;            
                var captured = CapturedMember.Define(id, src, outcome.Range, summary.Bits, outcome);                
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
        {
            try
            {
                var pSrc = jit(src).Ptr;
                var summary = Capture(exchange, id, pSrc);
                var outcome =  summary.Outcome;   
                var captured = CapturedMember.Define(id, src, outcome.Range, summary.Bits, outcome);                
                return exchange.CaptureComplete(outcome.State, captured);

            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;
            }
        }

        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src)
        {
            try
            {
                var pSrc = jit(src);
                var summary = Capture(exchange, id, pSrc);
                var outcome = summary.Outcome;
                var captured = CapturedMember.Define(id, src, outcome.Range, summary.Bits, outcome);  
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(in CaptureState state, CaptureTermCode tc, long start, long end, int delta)
            => CaptureOutcome.Define(state, ((ulong)start, (ulong)(end + delta)), tc);

        [MethodImpl(Inline)]
        static CaptureSummary Summary(in CaptureExchange exchange, in CaptureState state, OpIdentity id, CaptureTermCode tc, long start, long end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var raw = exchange.Target(0, (int)(end - start)).ToArray();
            var trimmed = exchange.Target(0, outcome.ByteCount).ToArray();
            var bits = CaptureBits.Define(raw, trimmed);
            return CaptureSummary.Define(outcome, bits);
        }

        [MethodImpl(Inline)]
        CaptureSummary Capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
            => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        CaptureSummary Capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)        
            => capture(exchange, id, src.ToPointer<byte>());

        [MethodImpl(Inline)]
        CaptureSummary capture(in CaptureExchange exchange, OpIdentity id, byte* pSrc)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;            
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(CaptureState);

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
        static CaptureState Step(in CaptureExchange exchange, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            exchange.Target(offset++) = code;
            location = (long)pSrc;
            return CaptureState.Define(id, offset, location, code);
        }
    }
}