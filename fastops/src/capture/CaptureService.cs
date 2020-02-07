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

    unsafe readonly struct CaptureService : ICaptureService
    {
        public CapturedMember Capture(OpIdentity id, MethodInfo src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src);
                //var dst = exchange.TargetBuffer;
                var cr = capture(pSrc, exchange);            
                var bytes = exchange.Target(0, cr.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, cr.Range, bytes, cr);                
                exchange.Complete(captured);
                return captured;
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        public CapturedMember Capture(OpIdentity id, DynamicDelegate src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src).Ptr;
                //var dst = exchange.TargetBuffer;
                var cr =  capture(pSrc, exchange);   
                var bytes = exchange.Target(0, cr.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, cr.Range, bytes, cr);                
                exchange.Complete(captured);
                return captured;

            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;
            }
        }

        public CapturedMember Capture(OpIdentity id, Delegate src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = jit(src);
                //var dst = exchange.TargetBuffer;
                var cr = capture(pSrc, exchange);
                var bytes = exchange.Target(0, cr.ByteCount).ToArray();
                var captured = CapturedMember.Define(id, src, cr.Range, bytes, cr);  
                exchange.Complete(captured);
                return captured;
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        const byte ZED = 0;
        
        const byte RET = 0xc3;
        
        const byte INTR = 0xcc;
        
        const byte SBB = 0x19;
        
        const byte FF = 0xff;

        [MethodImpl(Inline)]
        static CaptureTermCode? Scan4(in CaptureExchange exchange, int offset)
        {

            var x0 = exchange.Target(offset - 3);
            var x1 = exchange.Target(offset - 2);
            var x2 = exchange.Target(offset - 1);
            var x3 = exchange.Target(offset);
            var delta = -2;

            if(match((x0,RET), (x1, SBB)))
                return CTC_RET_SBB;
            else if(match((x0, RET), (x1, INTR)))
                return CTC_RET_INTR;
            else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                return CTC_RET_ZED_SBB;
            else if(match((x0, RET), (x1, ZED), (x2,ZED), (x3,ZED)))
                return CTC_RET_Zx3;
            else if(match((x0,INTR), (x1, INTR)))
                return CTC_INTRx2;
            else
                return null;
        }

        [MethodImpl(Inline)]
        static CaptureTermCode? Scan5(in CaptureExchange exchange, int offset)
        {
            var x0 = exchange.Target(offset - 5);
            var x1 = exchange.Target(offset - 4);
            var x2 = exchange.Target(offset - 3);
            var x3 = exchange.Target(offset - 2);
            var x4 = exchange.Target(offset - 1);
            
            if(match((x0,ZED), (x1,ZED), (x2,0x48), (x3,FF), (x4,0xe0)))
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

        static CaptureTermCode? CalcTerm(in CaptureExchange exchange, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = Scan4(exchange, offset);
                if(tc != null)
                {
                    delta = -2;
                    return tc;
                }
            }

            if(offset >= 5)
            {
                var tc = Scan5(exchange, offset);
                if(tc != null)
                    return CTC_JMP_RAX;
            }
                    
            if(offset >= 7 && Zx7(exchange,offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7_000;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_Zx7_RET;
            }
            
            return null;
        }

        CaptureCompletion capture(IntPtr src, in CaptureExchange exchange)
        {
 
            var pSrc = src.ToPointer<byte>();
            var limit = exchange.BufferLength - 1;
            var pSrcCurrent = pSrc;    
            var offset = 0;            
            int? ret_offset = null;

            CaptureCompletion Complete(CaptureTermCode tc, int delta)
                => CaptureCompletion.Define((ulong)pSrc, (ulong)((long)pSrcCurrent + delta), tc);

            while(offset < limit)
            {
                byte code = 0;                
                exchange.Target(offset++) = Read(pSrcCurrent++, ref code);  
                exchange.Accept(CaptureState.Define(offset, (ulong)pSrcCurrent, code));                

                if(ret_offset == null && code == RET)
                    ret_offset = offset;                 

                var tc = CalcTerm(exchange, offset,ret_offset, out var delta);
                if(tc != null)                
                    return Complete(tc.Value, delta);
            }
            return Complete(CTC_BUFFER_OUT,0);
        }
                     
        [MethodImpl(Inline)]
        ref byte Read(byte* pByte, ref byte dst)
        {
            dst = Unsafe.Read<byte>(pByte);
            return ref dst;
        }

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

        //static ReadOnlySpan<byte> JmpRaxCheck => new byte[]{0x00, 0x00, 0x48, 0xff, 0xe0};        

        // [MethodImpl(Inline)]
        // static bit CheckJmpRax(Span<byte> lookback, out CaptureTermCode termcode, out int takeback)        
        // {            
        //     const int ValidBytes = 5;
        //     termcode = lookback.StartsWith(JmpRaxCheck) ? CTC_JMP_RAX_OLD : 0;            
        //     takeback = termcode != 0 ? -JmpRaxCheck.Length - 1 - ValidBytes : 0;
        //     return termcode != 0;
        // }    

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