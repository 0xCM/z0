//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct EnumLiteral
    {
        public uint Index;

        public Literal Value;

        public TextBlock Description;

        [MethodImpl(Inline)]
        public EnumLiteral(uint index, Literal value, TextBlock desc)
        {
            Index = index;
            Value = value;
            Description = desc;
        }
    }

    public struct EnumLiteral<T>
    {
        public uint Index;

        public Literal<T> Value;

        public TextBlock Description;

        [MethodImpl(Inline)]
        public EnumLiteral(uint index, Literal<T> value, TextBlock desc)
        {
            Index = index;
            Value = value;
            Description = desc;
        }

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteral(EnumLiteral<T> src)
            => lang.untype(src);
    }
}