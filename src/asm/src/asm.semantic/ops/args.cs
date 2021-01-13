//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmSemantic
    {

        [MethodImpl(Inline)]
        public Args<A,B> args<A,B>(A a, B b)
            where A : unmanaged
            where B : unmanaged
                => new Args<A,B>(a, b);
    }
}