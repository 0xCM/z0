//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a relation between two values of homogenous type
    /// </summary>
    public struct Relation<A>
    {
        /// <summary>
        /// The relation name
        /// </summary>
        public readonly CharBlock32 Name;

        /// <summary>
        /// The first value
        /// </summary>
        public readonly A First;

        /// <summary>
        /// The second value
        /// </summary>
        public readonly A Second;

        /// <summary>
        /// The relation facets
        /// </summary>
        public readonly Facets Facets;

        [MethodImpl(Inline)]
        public Relation(CharBlock32 name, A a, A b, Facets facets)
        {
            Name = name;
            First = a;
            Second = b;
            Facets = facets;
        }
    }
}