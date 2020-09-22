//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Pairs a part with owned code
    /// </summary>
    public readonly struct ApiPartHexIndex
    {
        /// <summary>
        /// The owning part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The code in the set
        /// </summary>
        public readonly X86HostIndex[] Data;

        [MethodImpl(Inline)]
        public ApiPartHexIndex(PartId part, X86HostIndex[] src)
        {
            Part = part;
            Data = src;
        }
    }
}