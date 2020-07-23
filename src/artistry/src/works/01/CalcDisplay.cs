//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Displays;
    using static z;
    using static Konst;

    using M = CalcManaged;
    using N = CalcNative;
    using K = Kinds;

    public readonly struct CalcDisplay : IDisplay
    {
        public static CalcDisplay Service => default;

        static ReadOnlySpan<LocatedMethod> Slots
            => FunctionJit.jit(typeof(CalcSlots));

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

        public void Display()
        {
            var slots = MemSlots.from<CalcSlotIndex>(typeof(CalcSlots));
            ref readonly var add = ref slots[CalcSlotIndex.Add];
            ref readonly var sub = ref slots[CalcSlotIndex.Sub];
            ref readonly var mul = ref slots[CalcSlotIndex.Mul];
            ref readonly var div = ref slots[CalcSlotIndex.Div];

            var mulCode = CalculatorCode.mul_ᐤ8uㆍ8uᐤ;
            var divCode = CalculatorCode.div_ᐤ8uㆍ8uᐤ;
            var size = mulCode.Length;

            var x = As.uint8(4);
            var y = As.uint8(4);

            ref var mulRef = ref mul.Address.Ref<byte>();
            for(var i=0u; i<size; i++)
                seek(mulRef, i) = skip(divCode,i);

            var z1 = CalcSlots.mul(x,y);
            term.print(Displays.describe(K.mul(), x,y, z1));


            ref var divRef = ref div.Address.Ref<byte>();
            for(var i=0; i<size; i++)
                seek(divRef, i) = skip(mulCode,i);

            var z2 = CalcSlots.div(x,y);
            term.print(Displays.describe(K.div(), x,y, z2));

        }
    }
}