//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static CalcChecks;
    using static z;
    using static Konst;

    using M = CalcManaged;
    using N = CalcNative;
    using K = Kinds;
    using I = CalcOpIndex;

    [ApiHost]
    public readonly struct CalcDemo
    {
        static ReadOnlySpan<LocatedMethod> Slots
            => FunctionDynamic.jit(typeof(CalcSlots));

        void Display1()
        {
            var x = As.uint8(4);
            var y = As.uint8(16);
            var f = K.mul();

            var expect = M.eval(f, x, y);
            var actual = N.eval(f, x, y);
            var message = describe(f, x,y, expect, actual);

            term.print(message);
        }

        void Display2()
        {
            var slots = Slots;
            for(var i=0; i< Slots.Length; i++)
            {
                ref readonly var slot = ref skip(slots,i);
                term.print(slot);
            }
        }

        public static byte compute()
        {
            var ops = BinaryOps.arithmetic();
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
        public static byte compute(BinaryOps<byte> ops, byte a, byte b)
        {
            var c = ops[I.Add](a,b);
            var d = ops[I.Mul](a,c);
            var e = ops[I.Sub](d,a);
            return ops[I.Add](e,b);
        }

        [MethodImpl(Inline), Op]
        public static MemorySlots from(Type src)
            => FunctionDynamic.jit(src).Map(m => new SegRef(m.Address, m.Size));

        [MethodImpl(Inline)]
        public static MemorySlots<E> from<E>(Type src)
            where E : unmanaged, Enum
                => new MemorySlots<E>(from(src));

        [Op]
        public static void run(Span<string> dst, ref byte offset)
        {
            var slots = from<CalcOpIndex>(typeof(CalcSlots));
            ref readonly var add = ref slots[CalcOpIndex.Add];
            ref readonly var sub = ref slots[CalcOpIndex.Sub];
            ref readonly var mul = ref slots[CalcOpIndex.Mul];
            ref readonly var div = ref slots[CalcOpIndex.Div];

            var mulCode = CalculatorCode.mul_ᐤ8uㆍ8uᐤ;
            var divCode = CalculatorCode.div_ᐤ8uㆍ8uᐤ;
            var size = mulCode.Length;

            var x = uint8(4);
            var y = uint8(4);

            ref var mulRef = ref mul.Address.Ref<byte>();
            for(var i=0u; i<size; i++)
                seek(mulRef, i) = skip(divCode,i);

            var z1 = CalcSlots.mul(x,y);
            seek(dst, offset++) = (CalcChecks.describe(K.mul(), x,y, z1));

            ref var divRef = ref div.Address.Ref<byte>();
            for(var i=0; i<size; i++)
                seek(divRef, i) = skip(mulCode,i);

            var z2 = CalcSlots.div(x,y);
            seek(dst, offset++) = CalcChecks.describe(K.div(), x,y, z2);
        }
    }
}