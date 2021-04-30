//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static CalcDemoUtil;
    using static Part;
    using static memory;

    using M = CalcManagedDemo;
    using N = CalcNativeDemo;
    using I = CalcOpDemoIndex;
    using K = ApiClasses;

    [ApiHost]
    public readonly struct CalcDemo
    {
        void Display1()
        {
            var x = ScalarCast.uint8(4);
            var y = ScalarCast.uint8(16);
            var f = K.mul();

            var expect = M.eval(f, x, y);
            var actual = N.eval(f, x, y);
            var message = describe(f, x,y, expect, actual);

            term.print(message);
        }

        void Display2()
        {
            var slots = ClrDynamic.slots(typeof(CalcSlotsDemo));
            for(var i=0; i<slots.Length; i++)
            {
                ref readonly var slot = ref skip(slots,i);
                term.print(slot);
            }
        }

        public static byte compute()
        {
            var ops = BinaryOpsDemo.arithmetic();
            byte a = 1;
            byte b = 2;
            byte c = 0;
            byte d = 0;
            byte e = 0;
            for(byte i=0; i<50; i++)
            {
                c = ops[I.Add](a,i);
                d = ops[I.Mul](b,i);
                e = ops[I.Add](c,d);
                term.print($"i = {i} => e = {e}");

            }
            return e;
        }

        [MethodImpl(Inline),Op]
        public static byte compute(BinaryOpsDemo<byte> ops, byte a, byte b)
        {
            var c = ops[I.Add](a,b);
            var d = ops[I.Mul](a,c);
            var e = ops[I.Sub](d,a);
            return ops[I.Add](e,b);
        }


        [Op]
        public static void run(Span<string> dst, ref byte offset)
        {
            var slots = ClrDynamic.slots<CalcOpDemoIndex>(typeof(CalcSlotsDemo));
            ref readonly var add = ref slots[CalcOpDemoIndex.Add];
            ref readonly var sub = ref slots[CalcOpDemoIndex.Sub];
            ref readonly var mul = ref slots[CalcOpDemoIndex.Mul];
            ref readonly var div = ref slots[CalcOpDemoIndex.Div];

            var mulCode = CalculatorCode.mul_ᐤ8uㆍ8uᐤ;
            var divCode = CalculatorCode.div_ᐤ8uㆍ8uᐤ;
            var size = mulCode.Length;

            var x = ScalarCast.uint8(4);
            var y = ScalarCast.uint8(4);

            ref var mulRef = ref mul.Address.Ref<byte>();
            for(var i=0u; i<size; i++)
                seek(mulRef, i) = skip(divCode,i);

            var z1 = CalcSlotsDemo.mul(x,y);
            seek(dst, offset++) = (CalcDemoUtil.describe(K.mul(), x,y, z1));

            ref var divRef = ref div.Address.Ref<byte>();
            for(var i=0; i<size; i++)
                seek(divRef, i) = skip(mulCode,i);

            var z2 = CalcSlotsDemo.div(x,y);
            seek(dst, offset++) = CalcDemoUtil.describe(K.div(), x,y, z2);
        }
    }
}