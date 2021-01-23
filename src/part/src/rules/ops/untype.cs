//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static dynamic untype<T>(T src)
            => src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Consequent untype<T>(Consequent<T> src)
            where T : IEquatable<T>
                => src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static One untype<T>(One<T> src)
            where T : IEquatable<T>
                => src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Marker untype<T>(Marker<T> src)
            => new Marker(src.Symbols.Map(s => (dynamic)s));
    }
}