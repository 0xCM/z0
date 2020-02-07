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

    unsafe readonly struct CaptureService : ICaptureService
    {
        public Option<CapturedOpData> Capture(in OpIdentity id, Span<byte> src, in CaptureExchange exchange)
        {
            try
            {
                var result = capture(ref head(src), exchange);            
                var bytes = exchange.Target(0, result.ByteCount).ToArray();
                return CapturedOpData.Define(id,result, bytes);                
            }
            catch(Exception e)
            {
                errout(e);
                return none<CapturedOpData>();
            }
        }

        public CapturedMember Capture(in OpIdentity id, MethodInfo src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src);
                var result = capture(pSrc, exchange);            
                var bytes = exchange.Target(0, result.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, result.Range, bytes, result);                
                return exchange.Complete(captured);
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        public CapturedMember Capture(in OpIdentity id, in DynamicDelegate src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src).Ptr;
                var result =  capture(pSrc, exchange);   
                var bytes = exchange.Target(0, result.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, result.Range, bytes, result);                
                return exchange.Complete(captured);

            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;
            }
        }

        public CapturedMember Capture(in OpIdentity id, Delegate src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src);
                var result = capture(pSrc, exchange);
                var bytes = exchange.Target(0, result.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, result.Range, bytes, result);  
                return exchange.Complete(captured);
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
        static CaptureCompletion Complete(CaptureTermCode tc, long start, long end, int delta)
            => CaptureCompletion.Define((ulong)start, (ulong)(end + delta), tc);

        [MethodImpl(Inline)]
        CaptureCompletion capture(ref byte src, in CaptureExchange exchange)
            => capture((byte*)Unsafe.AsPointer(ref src), exchange);

        [MethodImpl(Inline)]
        CaptureCompletion capture(IntPtr src, in CaptureExchange exchange)
            => capture(src.ToPointer<byte>(), exchange);

        [MethodImpl(Inline)]
        CaptureCompletion capture(byte* pSrc, in CaptureExchange exchange)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;            
            int? ret_offset = null;
            var end = (long)pSrc;

            while(offset < limit)
            {
                var state = Step(exchange, ref offset, ref end, ref pSrc);                                
                exchange.Accept(state);                

                if(ret_offset == null && state.Data == RET)
                    ret_offset = offset;                 

                var tc = CalcTerm(exchange, offset, ret_offset, out var delta);
                if(tc != null)                
                    return Complete(tc.Value, start,end, delta);
            }
            return Complete(CTC_BUFFER_OUT,start,end,0);

        }
                     
    }
}