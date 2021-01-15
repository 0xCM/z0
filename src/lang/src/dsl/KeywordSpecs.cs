//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Part;
    using static memory;
    using static KeywordNames;

    [ApiHost]
    public unsafe struct KeywordSpecs
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Keyword<T> cell<T>(T t) => new Keyword<T>(pchar(Cell), t);
    }
}