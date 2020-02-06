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


    unsafe readonly struct MemberCapture : IMemberCapture
    {
        public CapturedMember Capture(OpIdentity id, MethodInfo src, in CaptureExchange exchange)
        {
            try
            {
                var pSrc = Jit.jit(src);
                var dst = exchange.TargetBuffer;
                var start = (ulong)pSrc;
                var result = capture(pSrc, exchange);            
                var end = result.End;
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return CapturedMember.Define(id, src, (start, end), code, result);         
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
                var pSrc = Jit.jit(src).Ptr;
                var dst = exchange.TargetBuffer;
                var start = (ulong)pSrc;       
                var result =  capture(pSrc, exchange);   
                var end = result.End;
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return CapturedMember.Define(id, src, (start, end), code, result);

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
                var pSrc = Jit.jit(src);
                var dst = exchange.TargetBuffer;
                var start = (ulong)pSrc;
                var result = capture(pSrc, exchange);
                var end = result.End;
                var bytesRead = (int)(end - start);
                var code = dst.Slice(0, bytesRead).ToArray();
                return CapturedMember.Define(id, src, (start, end), code, result);
            }
            catch(Exception e)
            {
                errout(e);
                return CapturedMember.Empty;                    
            }
        }

        NativeCaptureInfo capture(IntPtr src, in CaptureExchange exchange)
        {
            const byte ZED = 0;
            const byte RET = 0xc3;
            const byte INTR = 0xcc;
            const byte SBB = 0x19;
            const int Lookback_Count = 16;
 
            var pSrc = src.ToPointer<byte>();
            var dst = exchange.TargetBuffer;

            var maxcount = dst.Length - 1;
            var pSrcCurrent = pSrc;    
            var offset = 0;
            
            var ret_found = false;
            var ret_offset = 0ul;
            var takeback = 0;

            var tc = None;
            Span<byte> lookback = new byte[Lookback_Count];            
                       
            NativeCaptureInfo Capture(Span<byte> lookback, int delta)
                => NativeCaptureInfo.Define((ulong)pSrc, (ulong)((long)pSrcCurrent + delta), tc, lookback.ToArray());

            while(offset < maxcount)
            {
                byte code = 0;                
                dst[offset++] = Read(pSrcCurrent++, ref code);  
                exchange.Junction.Accept((offset, (ulong)pSrcCurrent, code), exchange);
                
                var lookstart = offset < Lookback_Count ? 0 : offset - Lookback_Count;
                lookback = dst.Slice(lookstart, Lookback_Count);

                if(!ret_found)
                {
                    ret_found = (code == RET);
                    if(ret_found)
                        ret_offset = (ulong)offset;
                }

                if(offset >= 4)
                {
                    var x0 = dst[offset - 3];
                    var x1 = dst[offset - 2];
                    var x2 = dst[offset - 1];
                    var x3 = dst[offset];
                    var end = 0ul;

                    if(match((x0,RET), (x1, SBB)))
                        tc = CTC_RET_SBB;
                    else if(match((x0, RET), (x1, INTR)))
                        tc = CTC_RET_INTR;
                    else if(match((x0, RET), (x1, ZED), (x2,SBB)))
                        tc = CTC_RET_ZED_SBB;
                    else if(match((x0, RET), (x1, ZED), (x2,ZED), (x3,ZED)))
                        tc = CTC_RET_Zx3;
                    else if(match((x0,INTR), (x1, INTR)))
                        tc = CTC_INTRx2;

                    if(tc != None)
                        return Capture(lookback, -2);
                }
            
                if(CheckJmpRax(lookback, out tc, out takeback))
                    return Capture(lookback, takeback);

                if(offset >= Lookback_Count 
                    && (dst[offset - 6] == ZED) 
                    && (dst[offset - 5] == ZED) 
                    && (dst[offset - 4] == ZED) 
                    && (dst[offset - 3] == ZED) 
                    && (dst[offset - 2] == ZED) 
                    && (dst[offset - 1] == ZED)                     
                    && (dst[offset - 0] == ZED)                     
                    )
                {
                    var end = 0ul;
                    tc = CTC_Zx7_000;

                    if(ret_found)
                    {
                        end = (ulong)pSrc + ret_offset;
                        tc = CTC_Zx7_RET;
                    }
                    else
                        end = (ulong)pSrcCurrent - 6;
                    
                    return NativeCaptureInfo.Define((ulong)pSrc, end, tc, lookback.ToArray());
                }
            }
            return NativeCaptureInfo.Define((ulong)pSrc, (ulong)pSrcCurrent, CTC_BUFFER_OUT, lookback.ToArray());           
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
        
        static ReadOnlySpan<byte> JmpRaxCheck => new byte[]{0x00, 0x00, 0x48, 0xff, 0xe0};        

        [MethodImpl(Inline)]
        static bit CheckJmpRax(Span<byte> lookback, out CaptureTermCode termcode, out int takeback)        
        {            
            const int ValidBytes = 5;
            termcode = lookback.StartsWith(JmpRaxCheck) ? CTC_JMP_RAX : 0;            
            takeback = termcode != 0 ? -JmpRaxCheck.Length - 1 - ValidBytes : 0;
            return termcode != 0;
        }
    
    }

}