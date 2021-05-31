//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmBlockLabel : IAsmLabel
    {
        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public AsmBlockLabel(Identifier name)
            => Name = name;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsNonEmpty;
        }

        public string Format()
            =>  Name.IsEmpty ? EmptyString : string.Format("{0}:", Name);

        public override string ToString()
            => Format();

        public static AsmBlockLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmBlockLabel(Identifier.Empty);
        }
    }
}