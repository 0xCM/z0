//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static ExtractTermCode;
    
    readonly struct Jitter
    {
        [MethodImpl(Inline)]
        public static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        public static IntPtr jit(Delegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static DynamicPointer jit(DynamicDelegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src.DynamicOp);
            return DynamicPointer.From(src);
        }        

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => jit(src.Untyped);
    }

    unsafe readonly struct CaptureCore : ICaptureCore
    {      
        public static ICaptureCore Service => default(CaptureCore);  

        [MethodImpl(Inline)]
        static CapturedCode DefineMember(OpIdentity id, MethodInfo src, ParsedCode bits, ExtractTermCode term)
            => CapturedCode.Define(id, null, src, bits.Unparsed, bits.Encoded, term);

        [MethodImpl(Inline)]
        static CapturedCode DefineMember(OpIdentity id, Delegate src, ParsedCode bits, ExtractTermCode term)
            => CapturedCode.Define(id, src, src.Method, bits.Unparsed, bits.Encoded, term);

        [MethodImpl(Inline)]
        static CapturedCode DefineMember(OpIdentity id, Delegate src, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => CapturedCode.Define(id, src, src.Method, extracted, parsed, term);

        public Option<ParsedOperation> ParseBuffer(in CaptureExchange exchange, OpIdentity id, Span<byte> src)
        {
            try
            {
                var parsed = capture(exchange, id, ref head(src));
                var outcome = parsed.Outcome;            
                var bytes = exchange.Target(0, outcome.ByteCount).ToArray();
                return ParsedOperation.Define(id, outcome, bytes);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<ParsedOperation>();
            }
        }

        public Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, MethodInfo src)
        {
            try
            {
                var pSrc = Jitter.jit(src);
                var summary = capture(exchange, id, pSrc);
                var outcome = summary.Outcome;            
                var captured = DefineMember(id, src, summary.Data, outcome.TermCode); 
                insist((MemoryAddress)pSrc, captured.Address);               
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<CapturedCode>();
            }
        }

        public Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, in DynamicDelegate src)
        {
            try
            {
                var pSrc = Jitter.jit(src).Handle;
                var summary = capture(exchange, id, pSrc);
                var outcome =  summary.Outcome;   
                var captured = CapturedCode.Define(id, src.DynamicOp, src.SourceMethod, summary.Data.Unparsed, summary.Data.Encoded, outcome.TermCode);                
                insist((MemoryAddress)pSrc,captured.Address);               
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error($"Capture service failure");
                term.error(e);
                return none<CapturedCode>();
            }
        }

        public Option<OperationCapture> Capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)
        {
            try
            {
                return capture(exchange, id, src);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<OperationCapture>();
            }
        }

        public Option<CapturedCode> Capture(in CaptureExchange exchange, OpIdentity id, Delegate src)
        {
            try
            {
                var pSrc = Jitter.jit(src);
                var summary = capture(exchange, id, pSrc);
                var outcome = summary.Outcome;
                var captured = DefineMember(id, src, summary.Data, outcome.TermCode);  
                insist((MemoryAddress)pSrc,captured.Address);               
                return exchange.CaptureComplete(outcome.State, captured);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<CapturedCode>();
            }
        }

        public Option<CapturedCode> Capture(in CaptureExchange exchange, MethodInfo src, params Type[] args)
        {
            if(src.IsOpenGeneric())
            {
                var target = src.Reify(args);                
                var id = Identities.Services.Diviner.DivineIdentity(target);
                return Capture(exchange, id, target);
            }
            else
                return Capture(exchange, src.Identify(), src);                
        }

        [MethodImpl(Inline)]
        OperationCapture capture(in CaptureExchange exchange, OpIdentity id, ref byte src)
            => capture(exchange, id, (byte*)Unsafe.AsPointer(ref src));

        [MethodImpl(Inline)]
        OperationCapture capture(in CaptureExchange exchange, OpIdentity id, IntPtr src)        
            => capture(exchange, id, src.ToPointer<byte>());

        [MethodImpl(Inline)]
        OperationCapture capture(in CaptureExchange exchange, OpIdentity id, byte* pSrc)
        {
            var limit = exchange.BufferLength - 1;
            var start = (long)pSrc;
            var offset = 0;            
            int? ret_offset = null;
            var end = (long)pSrc;
            var state = default(ExtractState);

            while(offset < limit)
            {
                state = Step(exchange, id, ref offset, ref end, ref pSrc);                                
                exchange.CaptureStep(state);                

                if(ret_offset == null && state.Captured == RET)
                    ret_offset = offset;                 

                var tc = CalcTerm(exchange, offset, ret_offset, out var delta);
                if(tc != null)         
                    return SummarizeParse(exchange, state, id, tc.Value, start, end, delta);
            }
            return SummarizeParse(exchange, state, id, CTC_BUFFER_OUT, start, end, 0);
        }                    

        [MethodImpl(Inline)]
        static ExtractState Step(in CaptureExchange exchange, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            exchange.Target(offset++) = code;
            location = (long)pSrc;
            return ExtractState.Define(id, offset, location, code);
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(in ExtractState state, ExtractTermCode tc, long start, long end, int delta)
            => CaptureOutcome.Define(state, ((ulong)start, (ulong)(end + delta)), tc);

        [MethodImpl(Inline)]
        static OperationCapture SummarizeParse(in CaptureExchange exchange, in ExtractState state, OpIdentity id, ExtractTermCode tc, long start, long end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var raw = exchange.Target(0, (int)(end - start)).ToArray();
            var trimmed = exchange.Target(0, outcome.ByteCount).ToArray();
            var bits = ParsedCode.Define((MemoryAddress)start, raw, trimmed);
            return new OperationCapture(id, outcome, bits);
        }

        static ExtractTermCode? CalcTerm(in CaptureExchange exchange, int offset, int? ret_offset, out int delta)
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
        static ExtractTermCode? Scan4(in CaptureExchange exchange, int offset, out int delta)
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
        static ExtractTermCode? Scan5(in CaptureExchange exchange, int offset, out int delta)
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
        static bool Zx7(in CaptureExchange exchange, int offset)
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
    }
}