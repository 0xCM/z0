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
    /// Defines an 32-bit address operand
    /// </summary>
    public readonly struct Address32 : IOpAddress<Address32,W32,uint>
    {
        [MethodImpl(Inline)]
        public Address32(uint src)
        {
            this.Location = src;
        }

        public uint Location {get;}
    }
}