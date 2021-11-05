//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using static Types.PrimalKind;

    [ApiHost]
    public readonly struct types
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static CellType cell(uint content, uint storage, PrimalKind @class)
            => new CellType(content, storage, @class);

        [MethodImpl(Inline), Op]
        public static CellType icell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.SignedInt);

        [MethodImpl(Inline), Op]
        public static CellType icell(uint content)
            => new CellType(content, content, PrimalKind.SignedInt);

        [MethodImpl(Inline), Op]
        public static CellType ucell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.UnsignedInt);

        [MethodImpl(Inline), Op]
        public static CellType ucell(uint content)
            => new CellType(content, content, PrimalKind.UnsignedInt);

        [MethodImpl(Inline), Op]
        public static CellType fcell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.Float);

        [MethodImpl(Inline), Op]
        public static CellType fcell(uint content)
            => new CellType(content, content, PrimalKind.Float);

        [MethodImpl(Inline)]
        public static Class<K,T> @class<K,T>(in Classifier<K,T> @class, uint ordinal)
            where K : unmanaged
        {
            ref readonly var kv = ref skip(@class.Kinds, ordinal);
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.Symbols,ordinal);
            return new Class<K,T>(ordinal, @class.Name, name, s.Expr.Text, kv, lv.Value);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Class<T> @class<T>(in Classifier<T> @class, uint ordinal)
        {
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.Symbols,ordinal);
            return new Class<T>(ordinal, @class.Name, name, s.Expr.Text, lv.Value);
        }

        [MethodImpl(Inline)]
        public static Class @class(in Classifier @class, uint ordinal)
        {
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.Symbols,ordinal);
            return new Class(ordinal, @class.Name, name, s.Expr.Text, lv.Value);
        }

        [Op, Closures(Closure)]
        public static Classifier untype<T>(in Classifier<T> src)
            where T : unmanaged
        {
            return new Classifier(src.Name,
                src._Partitions,
                src._Symbols,
                src.Values.MapArray(x => new LabeledValue<ulong>(x.Label, core.bw64(x.Value.Content))),
                src.Classes.MapArray(c => untype(c)));
        }

        [MethodImpl(Inline)]
        public static Class untype<T>(in Class<T> src)
            where T : unmanaged
                => new Class(src.Ordinal, src.ClassName, src.KindName, src.Symbol, bw64(src.Value));

        public static Classifier<T> unkind<K,T>(in Classifier<K,T> src)
            where K : unmanaged
            where T : unmanaged
                => new Classifier<T>(
                    src.Name,
                    src._ClassNames,
                    src.Symbols.MapArray(unkind),
                    src._Values,
                    src.Classes.MapArray(c => unkind(c))
                    );

        [MethodImpl(Inline)]
        public static Class<T> unkind<K,T>(in Class<K,T> src)
            where K : unmanaged
                => new Class<T>(src.Ordinal, src.ClassName, src.KindName, src.Symbol, src.Value);

        public static Classifier<K,T> classifier<K,T>()
            where K : unmanaged, Enum
            where T : unmanaged
                => ClassCache.classifier<K,T>();


        internal static string format(PrimalKind src)
            => src switch{
                UnsignedInt => "u",
                SignedInt => "i",
                Float => "f",
                _ => EmptyString
            };

        internal static Outcome parse(char src, out PrimalKind dst)
        {
            dst = PrimalKind.None;
            switch(src)
            {
                case 'i':
                    dst = PrimalKind.SignedInt;
                break;
                case 'u':
                    dst = PrimalKind.UnsignedInt;
                break;
                case 'f':
                    dst = PrimalKind.Float;
                break;
            }
            return dst != 0;
        }

        [MethodImpl(Inline)]
        static Sym unkind<K>(Sym<K> src)
            where K : unmanaged
                => src;
    }
}