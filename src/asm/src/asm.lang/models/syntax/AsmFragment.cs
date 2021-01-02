//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmFragment
    {
        public AsmFragmentKind Kind {get;}

        public string Data {get;}

        [MethodImpl(Inline)]
        public AsmFragment(string data, AsmFragmentKind kind)
        {
            Data = data;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmFragment((string data, AsmFragmentKind kind) src)
            => new AsmFragment(src.data, src.kind);
    }
}