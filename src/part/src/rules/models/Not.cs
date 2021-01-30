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
        /// <summary>
        /// Represents the logical negation of a distinguished subject
        /// </summary>
        public readonly struct Not : IRule<Not>
        {
            public dynamic Subject {get;}

            [MethodImpl(Inline)]
            public Not(dynamic src)
                => Subject = src;
        }

        /// <summary>
        /// Represents the logical negation of a distinguished subject
        /// </summary>
        public readonly struct Not<T> : IRule<Not<T>,T>
        {
            public T Subject {get;}

            [MethodImpl(Inline)]
            public Not(T src)
                => Subject = src;

            [MethodImpl(Inline)]
            public static implicit operator Not<T>(T src)
                => new Not<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator Not<T>(Not src)
                => new Not<T>(src.Subject);

            [MethodImpl(Inline)]
            public static implicit operator Not(Not<T> src)
                => new Not(src.Subject);
        }
    }
}