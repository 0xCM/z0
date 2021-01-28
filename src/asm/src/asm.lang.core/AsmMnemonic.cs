//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmMnemonic
    {
        public asci32 Name {get;}

        [MethodImpl(Inline)]
        public AsmMnemonic(asci32 name)
            => Name = name;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmMnemonic(string name)
            => new AsmMnemonic(name);
    }
}