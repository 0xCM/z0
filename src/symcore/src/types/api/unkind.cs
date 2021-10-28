//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct types
    {
        public static Classifier<T> unkind<K,T>(in Classifier<K,T> src)
            where K : unmanaged
            where T : unmanaged
                => new Classifier<T>(
                    src.ClassName,
                    src._ClassNames,
                    src.ClassSymbols.MapArray(unkind),
                    src._Values,
                    src.Classes.MapArray(c => unkind(c))
                    );

        [MethodImpl(Inline)]
        public static Class<T> unkind<K,T>(in Class<K,T> src)
            where K : unmanaged
                => new Class<T>(src.Ordinal, src.ClassName, src.KindName, src.Symbol, src.Value);

        [MethodImpl(Inline)]
        static Sym unkind<K>(Sym<K> src)
            where K : unmanaged
                => src;
    }
}