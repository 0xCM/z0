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
    /// Defines an 8-bit register and its content
    /// </summary>
    public readonly struct R8 : IRegister<R8,W8,byte>, IRegOp<byte>
    {
        public byte Content  {get;}

        public RegisterKind RegKind {get;}


        [MethodImpl(Inline)]
        public R8(byte value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator byte(R8 src)
            => src.Content;
    }
}