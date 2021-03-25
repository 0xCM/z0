//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct XedModels
    {
        public readonly struct XedForm
        {
            public Identifier Name {get;}

            public AsmMnemonic Mnemonic {get;}

            public AttributeKind Attributes {get;}

            public IsaKind IsaKind {get;}

            [MethodImpl(Inline)]
            public XedForm(Identifier name, AsmMnemonic monic, AttributeKind attribs, IsaKind isa)
            {
                Name = name;
                Mnemonic = monic;
                Attributes = attribs;
                IsaKind = isa;
            }

            public string Format()
                => string.Format("{0,-48} | {1}", Name, Mnemonic);

            public override string ToString()
                => Format();
        }
    }
}