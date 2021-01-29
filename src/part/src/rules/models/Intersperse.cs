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
        /// Specifies that the terms of an input sequence are interspersed by a specified marker
        /// </summary>
        public readonly struct Intersperse<T>
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