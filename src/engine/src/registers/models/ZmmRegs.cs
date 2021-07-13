//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Cells;
    using static core;

    public readonly struct ZmmRegs
    {
        readonly RegAlloc Alloc;

        [MethodImpl(Inline)]
        internal ZmmRegs(RegAlloc src)
            => Alloc = src;

        [MethodImpl(Inline)]
        public ref Cell128 r128(RegIndexCode i)
            => ref lo128(r512(i));

        [MethodImpl(Inline)]
        public ref Cell256 r256(RegIndexCode i)
            => ref lo256(r512(i));

        [MethodImpl(Inline)]
        public ref Cell512 r512(RegIndexCode i)
        {
            var address = Alloc.RegAddress((byte)i);
            var data = cover<Cell512>(address,1);
            return ref first(data);
        }
    }
}