//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Specifies that an element either occurs once or not at all
        /// </summary>
        public readonly struct OneOrNone<T>
            where T : IEquatable<T>
        {
            public T Element {get;}

            [MethodImpl(Inline)]
            public OneOrNone(T src)
                => Element = src;

            public MultiplicityKind Multiplicity
                => MultiplicityKind.ZeroOrOne;

            [MethodImpl(Inline)]
            public static implicit operator OneOrNone<T>(T src)
                => new OneOrNone<T>(src);
        }
    }
}