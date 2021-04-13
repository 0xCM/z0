//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct XedModels
    {
        const string xed = nameof(xed);

        public readonly struct XedForm
        {
            public ushort Index {get;}

            public IForm Identifier {get;}

            public IClass Class {get;}

            public Category Category {get;}

            public Index<AttributeKind> Attributes {get;}

            public IsaKind IsaKind {get;}

            public Extension Extension {get;}

            [MethodImpl(Inline)]
            public XedForm(ushort index, IForm key, IClass iclass, Category category, Index<AttributeKind> attribs, IsaKind isa, Extension ext)
            {
                Index = index;
                Identifier = key;
                Class = iclass;
                Category = category;
                Attributes = attribs;
                IsaKind = isa;
                Extension = ext;
            }

            const string FormatPattern = "{0,-8} | {1,-56} | {2,-32} | {3,-16} | {4,-16} | {5}";

            public static string Header
                => string.Format(FormatPattern, nameof(Index), nameof(Identifier), nameof(Class),
                     nameof(IsaKind),nameof(Extension), nameof(Attributes));

            public string Format()
                => string.Format(FormatPattern, Index, Identifier, Class, IsaKind, Extension, Attributes.Delimit(Chars.Comma));

            public override string ToString()
                => Format();
        }
    }
}