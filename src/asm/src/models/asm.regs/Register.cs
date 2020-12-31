//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Registers;

    public readonly struct Register
    {
        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegisterKind kind)
            => Kind = kind;

        public RegisterClass Class => api.@class(Kind);

    }
}