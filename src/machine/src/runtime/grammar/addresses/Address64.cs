//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct Address64 : IAddress<Address64,W64,ulong>
    {
        [MethodImpl(Inline)]
        public Address64(ulong src)
        {
            this.Location = src;
        }

        public ulong Location {get;}
    }    

}