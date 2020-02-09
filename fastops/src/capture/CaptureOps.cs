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
                var outcome = capture(ref head(src), exchange);            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var state = outcome.State;
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
                var outcome = capture(pSrc, exchange);            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);                
                var state = outcome.State;
                return exchange.Complete(state,captured);
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
                var outcome =  capture(pSrc, exchange);   
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);                
                var state = outcome.State;
                return exchange.Complete(state,captured);

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
                var outcome = capture(pSrc, exchange);
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);  
                var state = outcome.State;
                return exchange.Complete(state,captured);
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        [MethodImpl(Inline)]
        static byte Read(byte* pSrc)
            => Unsafe.Read<byte>(pSrc);

        [MethodImpl(Inline)]
        static CaptureState Step(in CaptureExchange exchange, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Read(pSrc++);
            exchange.Target(offset++) = code;
            location = (long)pSrc;
            return CaptureState.Define(offset,location,code);
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(in CaptureState state, CaptureTermCode tc, long start, long end, int delta)
            => CaptureOutcome.Define(state, (ulong)start, (ulong)(end + delta), tc);

        [MethodImpl(Inline)]
        CaptureOutcome capture(ref byte src, in CaptureExchange exchange)
            => capture((byte*)Unsafe.AsPointer(ref src), exchange);

        [MethodImpl(Inline)]
        CaptureOutcome capture(IntPtr src, in CaptureExchange exchange)
            => capture(src.ToPointer<byte>(), exchange);

        [MethodImpl(Inline)]
        CaptureOutcome capture(byte* pSrc, in CaptureExchange exchange)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;            
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(CaptureState);

            while(offset < limit)
            {
                state = Step(exchange, ref offset, ref end, ref pSrc);                                
                exchange.Accept(state);                

                if(ret_offset == null && state.Payload == RET)
                    ret_offset = offset;                 

                var tc = CalcTerm(exchange, offset, ret_offset, out var delta);
                if(tc != null)                
                    return Complete(state, tc.Value, start,end, delta);
            }
            return Complete(state, CTC_BUFFER_OUT,start,end,0);
        }                    
    }
}