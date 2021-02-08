//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a 64-bit register and its content
    /// </summary>
    public readonly struct R64 : IRegister<R64,W64,ulong>, IRegOp<ulong>
    {
        public ulong Content {get;}

        public RegisterKind RegKind {get;}

        [MethodImpl(Inline)]
        public R64(ulong value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator ulong(R64 src)
            => src.Content;
    }
}