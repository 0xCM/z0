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
    using static AsmCodes.LockPrefixCode;
    using static AsmCodes;

    public struct LegacyPrefixSet
    {
        byte LockOrRepeat;

        public SegOverride Seg;

        public SizeOverrideCode Operand;

        public SizeOverrideCode Address;

        public AsmCodes.LockPrefixCode Lock
        {
            [MethodImpl(Inline)]
            get => LockOrRepeat == (byte)LOCK ? LOCK : 0;
            [MethodImpl(Inline)]
            set => LockOrRepeat = (byte)value;
        }

        public RepeatPrefix Repeat
        {
            [MethodImpl(Inline)]
            get => Lock == 0 ? (RepeatPrefix)LockOrRepeat : 0;
            [MethodImpl(Inline)]
            set => LockOrRepeat = (byte)value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => @as<LegacyPrefixSet,uint>(this) == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static LegacyPrefixSet Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}