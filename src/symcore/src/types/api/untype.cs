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
        public static Classifier untype<T>(in Classifier<T> src)
            where T : unmanaged
        {
            return new Classifier(src.ClassName,
                src._ClassNames,
                src._Symbols,
                src.Values.MapArray(x => new LabeledValue<ulong>(x.Label, core.bw64(x.Value.Content))),
                src.Classes.MapArray(c => untype(c)));
        }

        [MethodImpl(Inline)]
        public static Class untype<T>(in Class<T> src)
            where T : unmanaged
                => new Class(src.Ordinal, src.ClassName, src.KindName, src.Symbol, bw64(src.Value));
    }
}