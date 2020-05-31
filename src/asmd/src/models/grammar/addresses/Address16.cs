//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct Address16 : IOpAddress<Address16,W16,ushort>
    {
        [MethodImpl(Inline)]
        public Address16(ushort src)
        {
            this.Location = src;
        }

        public ushort Location {get;}
    }
}