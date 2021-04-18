//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Symbols
    {
        const string SymFormatPattern = "{0,-8} | {1,-32} | {2,-32} | {3,-32} | {4,-8:d} | {5}";

        [Op]
        public static string header()
            => string.Format(SymFormatPattern, "Index", "Kind", "Name", "Expression", "Value", "Description");

        [Op]
        public static string format(Sym src)
            => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);

        [Op]
        public static string format(Sym8 src)
            => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);

        [Op]
        public static string format(Sym16 src)
            => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);

        public static string format<E>(Sym8<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);

        public static string format<E>(Sym16<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);

        public static string format<E>(Sym<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Type, src.Name, src.Expr, src.Kind, src.Description);
    }
}