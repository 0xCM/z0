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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnumLiteral untype<T>(EnumLiteral<T> src)
        {
            var dst = new EnumLiteral();
            dst.Index = src.Index;
            dst.Value = src.Value;
            dst.Description = src.Description;
            return dst;
        }

        [Op, Closures(Closure)]
        public static Enumeration untype<T>(Enumeration<T> src)
        {
            var dst = new Enumeration();
            dst.Namespace = src.Namespace;
            dst.Name = src.Name;
            dst.DataType = src.DataType;
            dst.Description = src.Description;
            dst.Literals = src.Literals.Select(untype);
            return dst;
        }
    }
}