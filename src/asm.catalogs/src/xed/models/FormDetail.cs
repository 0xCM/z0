//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct XedModels
    {
        public struct FormDetail
        {
            public ushort Index;

            public IForm Identifier;

            public IClass Class;

            public Category Category;

            public Index<AttributeKind> Attributes;

            public IsaKind IsaKind;

            public Extension Extension;

            public Index<FormOperand> Operands;

            [MethodImpl(Inline)]
            public FormDetail(ushort index, IForm key, IClass iclass, Category category, Index<AttributeKind> attribs, IsaKind isa, Extension ext)
            {
                Index = index;
                Identifier = key;
                Class = iclass;
                Category = category;
                Attributes = attribs;
                IsaKind = isa;
                Extension = ext;
                Operands = Index<FormOperand>.Empty;
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