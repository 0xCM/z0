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
    /// Defines a 64-bit immediate value
    /// </summary>
    public readonly struct Imm64 : ISized<Imm64,W64>
    {
        public readonly ulong Data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Imm64 src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm64(ulong src)
            => new Imm64(src);

        [MethodImpl(Inline)]
        public Imm64(ulong src)
        {
            Data = src;
        }
    }
}