//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a c/c++/c# style enumeration
    /// </summary>
    public struct Enumeration
    {
        public Name Namespace;

        public Identifier Name;

        public ConstantKind DataType;

        public TextBlock Description;

        public Index<EnumLiteral> Literals;
    }

    public struct Enumeration<T>
    {
        public Name Namespace;

        public Identifier Name;

        public ConstantKind DataType;

        public TextBlock Description;

        public Index<EnumLiteral<T>> Literals;

        public static implicit operator Enumeration(Enumeration<T> src)
            => lang.untype(src);
    }
}