//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct XedModels
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct XedFormDetail : IRecord<XedFormDetail>
        {
            public const string TableId = "xed.forms.details";

            public const byte FieldCount = 7;

            public ushort Index;

            public IForm Form;

            public IClass Class;

            public Category Category;

            public IsaKind IsaKind;

            public Extension Extension;

            public DelimitedIndex<AttributeKind> Attributes;

            [MethodImpl(Inline)]
            public XedFormDetail(ushort index, IFormType form, IClass iclass, Category category, Index<AttributeKind> attribs, IsaKind isa, Extension ext)
            {
                Index = index;
                Form = form;
                Class = iclass;
                Category = category;
                Attributes = Seq.delimit(Chars.Colon, 0, attribs.Storage);
                IsaKind = isa;
                Extension = ext;
            }

            public static ReadOnlySpan<byte> FieldWidths
                => new byte[FieldCount]{8,60,32,16,16,16,1};
       }
    }
}