//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a 32-bit register and its content
    /// </summary>
    public readonly struct R32 : IRegister<R32,W32,uint>
    {
        public uint Content  {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public R32(uint value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegisterClass Class
            => RegisterClass.GP;
    }
}