//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmCodes;

    using F = AsmCodes.RFlagBits;
    using I = AsmCodes.RFlagIndex;

    /// <summary>
    /// Defines the state of a <see cref='F'/> join
    /// </summary>
    [ApiComplete]
    public struct StatusFlags
    {
        RFlagBits State;

        [MethodImpl(Inline)]
        public StatusFlags(RFlagBits state)
            => State = state;

        [MethodImpl(Inline)]
        public StatusFlags(StatusFlagBits state)
            => State = (RFlagBits)state;

        [MethodImpl(Inline)]
        public bit CF()
            => (State & F.CF) != 0;

        [MethodImpl(Inline)]
        public void CF(bit cf)
            => State = (F)bit.set((ulong)State, (byte)I.CF, cf);

        [MethodImpl(Inline)]
        public bit PF()
            => (State & F.PF) != 0;

        [MethodImpl(Inline)]
        public void PF(bit pf)
            => State = (F)bit.set((ulong)State, (byte)I.PF, pf);

        [MethodImpl(Inline)]
        public bit AF()
            => (State & F.AF) != 0;

        [MethodImpl(Inline)]
        public void AF(bit af)
            => State = (F)bit.set((ulong)State, (byte)I.AF, af);

        [MethodImpl(Inline)]
        public bit OF()
            => (State & F.OF) != 0;

        [MethodImpl(Inline)]
        public void OF(bit of)
            => State = (F)bit.set((ulong)State, (byte)I.OF, of);

        [MethodImpl(Inline)]
        public bit SF()
            => (State & F.SF) != 0;

        [MethodImpl(Inline)]
        public void SF(bit sf)
            => State = (F)bit.set((ulong)State, (byte)I.SF, sf);

        [MethodImpl(Inline)]
        public bit ZF()
            => (State & F.ZF) != 0;

        [MethodImpl(Inline)]
        public void ZF(bit zf)
            => State = (F)bit.set((ulong)State, (byte)I.ZF, zf);

        [MethodImpl(Inline)]
        public static implicit operator StatusFlags(RFlagBits src)
            => new StatusFlags(src);

        [MethodImpl(Inline)]
        public static implicit operator RFlagBits(StatusFlags src)
            => src.State;

        [MethodImpl(Inline)]
        public static implicit operator StatusFlags(StatusFlagBits src)
            => new StatusFlags(src);

        [MethodImpl(Inline)]
        public static implicit operator StatusFlagBits(StatusFlags src)
            => (StatusFlagBits)src.State;
    }
}