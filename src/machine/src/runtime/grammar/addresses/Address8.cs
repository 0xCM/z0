//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct Address8 : IAddress<Address8,W8,byte>
    {
        [MethodImpl(Inline)]
        public Address8(byte src)
        {
            this.Location = src;
        }

        public byte Location {get;}
    }
}