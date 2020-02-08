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

    static class CaptureHelpers
    {
        public static CaptureTermCode? CalcTerm(in CaptureExchange exchange, int offset, int? ret_offset, out int delta)
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
                    
            if(offset >= 7 && Zx7(exchange,offset))
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
        
        public const byte RET = 0xc3;
        
        const byte INTR = 0xcc;
        
        const byte SBB = 0x19;
        
        const byte FF = 0xff;


        [MethodImpl(Inline)]
        static CaptureTermCode? Scan4(in CaptureExchange exchange, int offset, out int delta)
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
        static CaptureTermCode? Scan5(in CaptureExchange exchange, int offset, out int delta)
        {
            var x0 = exchange.Target(offset - 5);
            var x1 = exchange.Target(offset - 4);
            var x2 = exchange.Target(offset - 3);
            var x3 = exchange.Target(offset - 2);
            var x4 = exchange.Target(offset - 1);
            delta = 0;
            
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
        public static IntPtr jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        public static IntPtr jit(Delegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d);
            return d.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static DynamicPointer jit(DynamicDelegate d)
        {   
            RuntimeHelpers.PrepareDelegate(d.DynamicOp);
            return d.GetDynamicPointer();
        }
    }
}