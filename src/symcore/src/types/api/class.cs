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

    partial struct types
    {
        [MethodImpl(Inline)]
        public static Class<K,T> @class<K,T>(in Classifier<K,T> @class, uint ordinal)
            where K : unmanaged
        {
            ref readonly var kv = ref skip(@class.Kinds, ordinal);
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.ClassSymbols,ordinal);
            return new Class<K,T>(ordinal, @class.ClassName, name, s.Expr.Text, kv, lv.Value);
        }

        [MethodImpl(Inline)]
        public static Class<T> @class<T>(in Classifier<T> @class, uint ordinal)
        {
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.ClassSymbols,ordinal);
            return new Class<T>(ordinal, @class.ClassName, name, s.Expr.Text, lv.Value);
        }

        [MethodImpl(Inline)]
        public static Class @class(in Classifier @class, uint ordinal)
        {
            ref readonly var lv = ref skip(@class.Values, ordinal);
            ref readonly var name = ref skip(@class.ClassNames, ordinal);
            ref readonly var s = ref skip(@class.ClassSymbols,ordinal);
            return new Class(ordinal, @class.ClassName, name, s.Expr.Text, lv.Value);
        }
    }
}