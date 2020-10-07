//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct R64 : IRegister<R64,W64,ulong>
    {
        public ulong Content  {get;}

        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public R64(ulong value, RegisterKind kind)
        {
            Content = value;
            Kind = kind;
        }

        public RegisterClass Class
            => RegisterClass.GP;
    }
}