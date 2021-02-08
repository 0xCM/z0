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
    /// Defines a 32-bit register and its content
    /// </summary>
    public readonly struct R32 : IRegister<R32,W32,uint>, IRegOp<uint>
    {
        public uint Content  {get;}

        public RegisterKind RegKind {get;}

        [MethodImpl(Inline)]
        public R32(uint value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator uint(R32 src)
            => src.Content;
    }
}