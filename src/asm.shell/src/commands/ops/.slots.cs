//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial class AsmCmdService
    {
        [CmdOp(".slots")]
        unsafe Outcome Slots(CmdArgs args)
        {
            var result = Outcome.Success;
            var slots = ClrDynamic.slots(typeof(SlotBox64)).View;
            var box = new SlotBox64();
            var code = GetArg;
            for(byte i=0; i<slots.Length; i++)
            {
                ref readonly var slot = ref skip(slots,i);

                var pDst = slot.Address.Pointer<byte>();
                var length = code.Length;
                for(var j=0; j<length; j++)
                    seek(pDst,j) = skip(code,j);

                ulong Dispatch(byte index, ulong a)
                    => index switch
                    {
                        0 => box.f0(a*2),
                        1 => box.f1(a*3),
                        2 => box.f2(a*4),
                        3 => box.f3(a*5),
                        _ => 0
                    };

                var @return = Dispatch(i,i);
                Write(string.Format("{0}: {1}", i, @return));
            }

            return result;
        }

        // mov rax,rcx -> ret
        static ReadOnlySpan<byte> GetThis => new byte[]{0x48, 0x8b, 0xc1, 0xc3};

        // mov rax,rdx -> ret
        static ReadOnlySpan<byte> GetArg => new byte[]{0x48, 0x8b, 0xc2, 0xc3};

        static ReadOnlySpan<byte> JmpRdx => new byte[]{0xff, 0xe2};
    }

    readonly struct SlotBox64
    {
        readonly ulong A;

        [MethodImpl(NotInline)]
        public ulong f0(ulong a)
        {
            return ulong.MaxValue;
        }

        [MethodImpl(NotInline)]
        public ulong f1(ulong a0)
        {
            return a0 - 0xAAAAAAAAAA;
        }

        [MethodImpl(NotInline)]
        public ulong f2(ulong a0)
        {
            return A % a0;
        }

        [MethodImpl(NotInline)]
        public ulong f3(ulong a0)
        {
            return a0 * A;
        }
    }
}