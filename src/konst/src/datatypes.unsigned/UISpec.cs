//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Unsigned
    {
        public byte EffectiveWidth {get;}

        public ulong MinValue => 0;

        public ulong MaxValue => Pow2.pow(EffectiveWidth);

        public ulong Modulus => MaxValue + 1;
    }
}