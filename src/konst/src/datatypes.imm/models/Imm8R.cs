//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an 8-bit immediate that is potentially refined
    /// </summary>
    [Datatype]
    public readonly struct Imm8R : IImmValue<Imm8R,W8,byte>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public Imm8R(byte value)
            => Content = value;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8R imm8)
            => imm8.Content;
    }
}