//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmCodes;

    using I = AsmCodes.RFlagIndex;

    [ApiComplete]
    public struct StatusFlags
    {
        bit _CF;

        bit _PF;

        bit _AF;

        bit _OF;

        bit _SF;

        bit _ZF;

        [MethodImpl(Inline)]
        public StatusFlags(bit cf = default, bit pf = default, bit af = default, bit of = default, bit zf = default, bit sf = default)
        {
            _CF = cf;
            _PF = pf;
            _AF = af;
            _ZF = zf;
            _OF = of;
            _SF = sf;
        }

        [MethodImpl(Inline)]
        public bit CF()
            => _CF;

        [MethodImpl(Inline)]
        public void CF(bit cf)
            => _CF = cf;

        [MethodImpl(Inline)]
        public bit PF()
            => _PF;

        [MethodImpl(Inline)]
        public void PF(bit pf)
            => _PF = pf;

        [MethodImpl(Inline)]
        public bit AF()
            => _AF;

        [MethodImpl(Inline)]
        public void AF(bit af)
            => _AF = af;

        [MethodImpl(Inline)]
        public bit OF()
            => _OF;

        [MethodImpl(Inline)]
        public void OF(bit of)
            => _OF = of;

        [MethodImpl(Inline)]
        public bit SF()
            => _SF;

        [MethodImpl(Inline)]
        public void SF(bit sf)
            => _SF = sf;

        [MethodImpl(Inline)]
        public bit ZF()
            => _ZF;

        [MethodImpl(Inline)]
        public void ZF(bit zf)
            => _ZF = zf;

        [MethodImpl(Inline)]
        public void Read(RFlagBits src)
        {
            _CF = bit.test((ulong)src, (byte)I.CF);
            _PF = bit.test((ulong)src, (byte)I.PF);
            _AF = bit.test((ulong)src, (byte)I.AF);
            _OF = bit.test((ulong)src, (byte)I.OF);
            _SF = bit.test((ulong)src, (byte)I.SF);
            _ZF = bit.test((ulong)src, (byte)I.ZF);
        }

        [MethodImpl(Inline)]
        public void Write(ref RFlagBits dst)
        {
            var src = u64(dst);
            bit.set(ref src, (byte)I.CF, _CF);
            bit.set(ref src, (byte)I.PF, _PF);
            bit.set(ref src, (byte)I.AF, _AF);
            bit.set(ref src, (byte)I.OF, _OF);
            bit.set(ref src, (byte)I.SF, _SF);
            bit.set(ref src, (byte)I.ZF, _ZF);
        }
    }
}