//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EFlagSymbol
    {
        public asci4 Name {get;}

        [MethodImpl(Inline)]
        public EFlagSymbol(asci4 name)
            => Name = name;

        [MethodImpl(Inline)]
        public static implicit operator EFlagSymbol(asci4 name)
            => new EFlagSymbol(name);

        [MethodImpl(Inline)]
        public static implicit operator EFlagSymbol((AsciCharCode a, AsciCharCode b) src)
            => new EFlagSymbol(Asci.define(src.a, src.b, AsciNone));

        [MethodImpl(Inline)]
        public static implicit operator EFlagSymbol(Pair<AsciCharCode> src)
            => new EFlagSymbol(Asci.define(src.Left, src.Right));

        [MethodImpl(Inline)]
        public static implicit operator EFlagSymbol(Triple<AsciCharCode> src)
            => new EFlagSymbol(Asci.define(src.First, src.Second, src.Third));
    }
}