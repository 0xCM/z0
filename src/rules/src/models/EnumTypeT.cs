//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct EnumType<T> : IRuleDataType<EnumType<T>>
        {
            public string Namespace;

            public string Name;

            public ConstantKind DataType;

            public string Description;

            public Index<EnumLiteral<T>> Literals;

            public EnumType Untype()
            {
                var dst = new EnumType();
                dst.Namespace = Namespace;
                dst.Name = Name;
                dst.DataType = DataType;
                dst.Description = Description;
                dst.Literals = Literals.Select(l => l.Untype());
                return dst;
            }

            public static implicit operator EnumType(EnumType<T> src)
                => src.Untype();
        }
    }
}