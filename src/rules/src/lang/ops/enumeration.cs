//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{

    using static Root;
    partial struct lang
    {
        [Op, Closures(Closure)]
        public static Enumeration<T> enumeration<T>(string ns, string name, ConstantKind dt, string desc, params EnumLiteral<T>[] literals)
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
        public static Enumeration<byte> enumeration(string ns, string name, Index<EnumLiteral<byte>> literals, string desc = null)
            => enumeration<byte>(ns,name, ConstantKind.Int8u, desc ?? EmptyString, literals);
    }
}