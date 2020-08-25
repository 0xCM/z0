//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SegmentPrefix : INullity
    {
        public readonly IceRegister Register;

        [MethodImpl(Inline)]
        public SegmentPrefix(IceRegister src)
            => Register = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Register == 0;
        }

        public static SegmentPrefix Empty
            => default;
    }
}