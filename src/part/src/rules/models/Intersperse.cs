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
        public readonly struct Intersperse : IRule<Intersperse>
        {
            public dynamic Insert {get;}

            [MethodImpl(Inline)]
            public Intersperse(dynamic insert)
            {
                Insert = insert;
            }
        }

        /// <summary>
        /// Specifies that the terms of an input sequence are interspersed by a specified marker
        /// </summary>
        public readonly struct Intersperse<T> : IRule<Intersperse<T>,T>
        {
            public T Insert {get;}

            [MethodImpl(Inline)]
            public Intersperse(T insert)
            {
                Insert = insert;
            }
        }
    }
}