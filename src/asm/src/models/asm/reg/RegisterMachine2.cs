//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RegisterBanks;
    using static z;

    public readonly struct RegisterMachine
    {
        public static RegisterMachine create()
            => new RegisterMachine(alloc(w512,32), alloc(w64, 16));

        readonly RV512 V;

        readonly Gp64 Gp;

        internal RegisterMachine(RV512 v, Gp64 gp)
        {
            V = v;
            Gp = gp;
        }

        [MethodImpl(Inline)]
        ref Cell512 r512(byte i)
            => ref V.r512(i);

        [MethodImpl(Inline)]
        ref Cell256 r256(byte i)
            => ref V.r256(i);

        [MethodImpl(Inline)]
        ref Cell128 r128(byte i)
            => ref V.r128(i);

        [MethodImpl(Inline)]
        ref Cell64 r64(byte i)
            => ref Gp.r64(i);

        [MethodImpl(Inline)]
        ref Cell32 r32(byte i)
            => ref Gp.r32(i);

        [MethodImpl(Inline)]
        ref Cell16 r16(byte i)
            => ref Gp.r16(i);

        [MethodImpl(Inline)]
        ref Cell8 r8(byte i)
            => ref Gp.r8(i);
    }
}