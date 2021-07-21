//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    partial struct Rules
    {
        [Op, Closures(Closure)]
        public static EnumType<T> enumtype<T>(string ns, string name, ConstantKind dt, string desc, params EnumLiteral<T>[] literals)
        {
            var dst = new EnumType<T>();
            dst.Namespace = ns;
            dst.Name = name;
            dst.DataType = dt;
            dst.Description = desc;
            dst.Literals = literals;
            return dst;
        }

        [Op]
        public static EnumType<byte> enumtpe(string ns, string name, Index<EnumLiteral<byte>> literals, string desc = null)
            => enumtype<byte>(ns,name, ConstantKind.Int8u, desc ?? EmptyString, literals);
    }
}