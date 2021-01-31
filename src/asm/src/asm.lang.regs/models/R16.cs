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
    public readonly struct R16 : IRegister<R16,W16,ushort>
    {
        public ushort Content  {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public R16(ushort value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegClass Class
            => RegClass.GP;
    }
}