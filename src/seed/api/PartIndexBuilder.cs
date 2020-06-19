//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartIndexBuilder : IPartIndexBuilder
    {
        /// <summary>
        /// Creates the builder, not the index
        /// </summary>
        public static IPartIndexBuilder Service => default(PartIndexBuilder);

        /// <summary>
        /// Creates an index over the known parts
        /// </summary>
        [MethodImpl(Inline)]
        public PartIndex Build()
            => PartIndex.Define(KnownParts.Service.Known);
    }
}