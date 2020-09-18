//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a sequence of arrows with a common basepoint
    /// </summary>
    public readonly struct Arrows<T>
    {
        public readonly T Client;

        public readonly T[] Suppliers;

        [MethodImpl(Inline)]
        public Arrows(T client, T[] src)
        {
            Client = client;
            Suppliers = src;
        }
    }
}
