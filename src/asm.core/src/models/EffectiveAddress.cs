//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Vol I, 4-6
    /// </summary>
    public readonly struct EffectiveAddress
    {
        public MemoryAddress Location {get;}

        [MethodImpl(Inline)]
        public EffectiveAddress(MemoryAddress address)
        {
            Location = address;
        }

        [MethodImpl(Inline)]
        public static implicit operator EffectiveAddress(MemoryAddress src)
            => new EffectiveAddress(src);

        public string Format()
            => Location.Format();

        public override string ToString()
            => Format();
    }
}