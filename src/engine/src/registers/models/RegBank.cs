//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;
    using static AsmRegBanks;

    [ApiComplete]
    public readonly ref struct RegBank
    {
        readonly ZmmBank V;

        readonly Gp64Bank Gp;

        [MethodImpl(Inline)]
        internal RegBank(ZmmBank v, Gp64Bank gp)
        {
            V = v;
            Gp = gp;
        }

        [MethodImpl(Inline)]
        public ref Cell512 r512(RegIndex r)
            => ref V.r512(r);

        [MethodImpl(Inline)]
        public ref Cell256 r256(RegIndex r)
            => ref V.r256(r);

        [MethodImpl(Inline)]
        public ref Cell128 r128(RegIndex r)
            => ref V.r128(r);

        [MethodImpl(Inline)]
        public ref Cell32 r32(RegIndex r)
            => ref Gp.r32(r);

        [MethodImpl(Inline)]
        public ref Cell64 r64(RegIndex r)
            => ref Gp.r64(r);

        [MethodImpl(Inline)]
        public ref Cell16 r16(RegIndex r)
            => ref Gp.r16(r);

        [MethodImpl(Inline)]
        public ref Cell8 r8(RegIndex r)
            => ref Gp.r8(r);

        [MethodImpl(Inline)]
        public ref Cell8 r(W8 w, RegIndex i)
            => ref Gp.r8(i);

        [MethodImpl(Inline)]
        public ref Cell16 r(W16 w, RegIndex i)
            => ref Gp.r16(i);

        [MethodImpl(Inline)]
        public ref Cell32 r(W32 w, RegIndex i)
            => ref Gp.r32(i);

        [MethodImpl(Inline)]
        public ref Cell64 r(W64 w, RegIndex i)
            => ref Gp.r64(i);

        [MethodImpl(Inline)]
        public ref Cell128 r(W128 w, RegIndex i)
            => ref V.r128(i);

        [MethodImpl(Inline)]
        public ref Cell256 r(W256 w, RegIndex i)
            => ref V.r256(i);

        [MethodImpl(Inline)]
        public ref Cell512 r(W512 w, RegIndex i)
            => ref V.r512(i);

        public ref Cell8 this[W8 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w8, i);
        }

        public ref Cell16 this[W16 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w16, i);
        }

        public ref Cell32 this[W32 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w32, i);
        }

        public ref Cell64 this[W64 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w64, i);
        }

        public ref Cell128 this[W128 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w128, i);
        }

        public ref Cell256 this[W256 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w256, i);
        }

        public ref Cell512 this[W512 w, RegIndex i]
        {
            [MethodImpl(Inline)]
            get => ref r(w512, i);
        }
    }
}