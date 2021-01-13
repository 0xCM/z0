//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RegMachine512
    {
        readonly RegBank512 V;

        readonly RegBank64 Gp;

        [MethodImpl(Inline)]
        internal RegMachine512(RegBank512 v, RegBank64 gp)
        {
            V = v;
            Gp = gp;
        }

        [MethodImpl(Inline)]
        public ref Cell512 r512(byte i)
            => ref V.r512(i);

        [MethodImpl(Inline)]
        public ref Cell256 r256(byte i)
            => ref V.r256(i);

        [MethodImpl(Inline)]
        public ref Cell128 r128(byte i)
            => ref V.r128(i);

        [MethodImpl(Inline)]
        public ref Cell64 r64(byte i)
            => ref Gp.r64(i);

        [MethodImpl(Inline)]
        public ref Cell32 r32(byte i)
            => ref Gp.r32(i);

        [MethodImpl(Inline)]
        public ref Cell16 r16(byte i)
            => ref Gp.r16(i);

        [MethodImpl(Inline)]
        public ref Cell8 r8(byte i)
            => ref Gp.r8(i);
    }
}