//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Vol I, 4-6: In 64-bit mode, a near pointer is 64 bits and equates to an effective address
    /// </summary>
    public readonly struct NearPtr
    {
        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public NearPtr(MemoryAddress address)
        {
            Address = address;
        }

        public string Format()
            => Address.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator NearPtr(MemoryAddress src)
            => new NearPtr(src);

        [MethodImpl(Inline)]
        public static implicit operator EffectiveAddress(NearPtr src)
            => new NearPtr(src.Address);
    }

}