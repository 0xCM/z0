//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmContextProvider
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static AsmContextProvider create(IAsmContext src)
            => new AsmContextProvider(src);

        [MethodImpl(Inline)]
        internal AsmContextProvider(IAsmContext src)
            => Context = src;
    }
}