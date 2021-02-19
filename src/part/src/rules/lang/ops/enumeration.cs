//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [Op, Closures(Closure)]
        public static Enumeration<T> enumeration<T>(Name ns, Identifier name, ConstantKind dt, TextBlock desc, params EnumLiteral<T>[] literals)
        {
            var dst = new Enumeration<T>();
            dst.Namespace = ns;
            dst.Name = name;
            dst.DataType = dt;
            dst.Description = desc;
            dst.Literals = literals;
            return dst;
        }

        [Op]
        public static Enumeration<byte> enumeration(Name ns, Identifier name, Index<EnumLiteral<byte>> literals, TextBlock? desc = null)
            => enumeration<byte>(ns,name, ConstantKind.Int8u, desc ?? TextBlock.Empty, literals);
    }
}