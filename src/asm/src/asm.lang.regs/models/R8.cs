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
    public readonly struct R8 : IRegister<R8,W8,byte>
    {
        public byte Content  {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public R8(byte value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegisterClass Class
            => RegisterClass.GP;
    }
}