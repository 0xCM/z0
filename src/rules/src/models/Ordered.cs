//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    partial struct RuleModels
    {
        public readonly struct Ordered : IRule<Ordered>
        {


        }

        /// <summary>
        /// Specifies that a sequence of comparable elements should be ordered
        /// </summary>
        public readonly struct Ordered<T> : IRule<Ordered<T>,T>
            where T : IComparable<T>
        {
            public static implicit operator Ordered(Ordered<T> src)
                => default;
        }
    }
}