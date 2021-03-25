//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;

    public readonly struct XedForm
    {
        public Identifier Name {get;}

        public AsmMnemonic Mnemonic {get;}

        public XedAttributeKind Attributes {get;}

        public XedIsaKind IsaKind {get;}

        public XedForm(Identifier name, AsmMnemonic monic, XedAttributeKind attribs, XedIsaKind isa)
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