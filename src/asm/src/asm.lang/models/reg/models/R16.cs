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
    /// Defines a 16-bit register and its content
    /// </summary>
    public readonly struct R16 : IRegister<R16,W16,ushort>, IRegOp16<ushort>
    {
        public ushort Content  {get;}

        public RegisterKind RegKind {get;}

        [MethodImpl(Inline)]
        public R16(ushort value, RegisterKind kind)
        {
            Content = value;
            RegKind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator ushort(R16 src)
            => src.Content;
    }
}