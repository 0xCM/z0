//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a 16-bit immediate value
    /// </summary>
    public readonly struct Imm16 : ISized<Imm16,W16>
    {
        public readonly ushort Data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(Imm16 src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm16(ushort src)
            => new Imm16(src);

        [MethodImpl(Inline)]
        public Imm16(ushort src)
        {
            Data = src;
        }
    }
}