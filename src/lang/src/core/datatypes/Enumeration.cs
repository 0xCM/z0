//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public Enumeration Untype()
        {
            var dst = new Enumeration();
            dst.Namespace = Namespace;
            dst.Name = Name;
            dst.DataType = DataType;
            dst.Description = Description;
            dst.Literals = Literals.Select(l => l.Untype());
            return dst;
        }

        public static implicit operator Enumeration(Enumeration<T> src)
            => src.Untype();
    }
}