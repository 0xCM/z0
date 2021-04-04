//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct Symbols
    {
        const string SymFormatPattern = "{0,-8} | {1,-32} | {2,-32} | {3}";

        [Op]
        public static string header()
            => string.Format(SymFormatPattern, "Index", "Kind", "Name", "Expression");

        [Op]
        public static string format(Sym8 src)
            => string.Format(SymFormatPattern, src.Index, src.Kind, src.Name, src.Expression);

        [Op]
        public static string format(Sym16 src)
            => string.Format(SymFormatPattern, src.Index, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym8<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym16<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Index, src.Kind, src.Name, src.Expression);

        [Op]
        public static string format(Token src)
            => src.Description.IsEmpty
            ? string.Format("{0,-24} | {1,-8} | {2,-12} | {3}",
                src.Literal.Type, src.Index, text.ifempty(src.Identifier, RP.EmptySymbol), text.ifempty(src.SymbolText, RP.EmptySymbol))
            : string.Format("{0,-24} | {1,-8} | {2,-12} | {3} | {4}",
                src.Literal.Type, src.Index, text.ifempty(src.Identifier, RP.EmptySymbol), text.ifempty(src.SymbolText, RP.EmptySymbol), src.Description);

    }
}