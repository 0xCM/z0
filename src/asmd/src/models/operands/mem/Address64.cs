//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    /// <summary>
    /// Defines a 64-bit address operand
    /// </summary>
    public readonly struct Address64 : IOpAddress<Address64,W64,ulong>
    {
        [MethodImpl(Inline)]
        public Address64(ulong src)
        {
            this.Location = src;
        }

        public ulong Location {get;}
    }    
}