//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct Address32 : IAddress<Address32,W32,uint>
    {
        [MethodImpl(Inline)]
        public Address32(uint src)
        {
            this.Location = src;
        }

        public uint Location {get;}
    }

}