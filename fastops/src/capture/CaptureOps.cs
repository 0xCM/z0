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
                var outcome = Capture(exchange, id, pSrc).Outcome;            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);                
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
                var outcome =  Capture(exchange,id, pSrc).Outcome;   
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);                
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
                var outcome = Capture(exchange,id, pSrc).Outcome;
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, outcome.Range, bytes, outcome);  
                return exchange.CaptureComplete(outcome.State, captured);
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
        static CaptureOutcome Complete(in CaptureState state, CaptureTermCode tc, long start, long end, int delta)
            => CaptureOutcome.Define(state, (ulong)start, (ulong)(end + delta), tc);

        [MethodImpl(Inline)]
        static CaptureDataset Dataset(in CaptureExchange exchange, in CaptureState state, OpIdentity id, CaptureTermCode tc, long start, long end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var trimmed = exchange.Target(0, outcome.ByteCount).ToArray();
            var buffer = exchange.Target(0, (int)(end - start)).ToArray();
            return CaptureDataset.Define(id, outcome, buffer, trimmed);
        }

        [MethodImpl(Inline)]
        CaptureDataset Capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
            => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        CaptureDataset Capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)        
            => capture(exchange, id, src.ToPointer<byte>());

        // [MethodImpl(Inline)]
        // CaptureOutcome capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
        //     => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        // [MethodImpl(Inline)]
        // CaptureOutcome capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)        
        //     => capture(exchange, id, src.ToPointer<byte>());

        [MethodImpl(Inline)]
        CaptureDataset capture(in CaptureExchange exchange, OpIdentity id, byte* pSrc)
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
                {       
                    return Dataset(exchange, state, id, tc.Value, start, end, delta);
                    //return Complete(state, tc.Value, start, end, delta);
                }
            }
            return Dataset(exchange, state, id, CTC_BUFFER_OUT, start, end, 0);

            //return Complete(state, CTC_BUFFER_OUT, start, end, 0);
        }                    

        [MethodImpl(Inline)]
        static CaptureState Step(in CaptureExchange exchange, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Read(pSrc++);
            exchange.Target(offset++) = code;
            location = (long)pSrc;
            return CaptureState.Define(id, offset, location,code);
        }
    }
}