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
    public readonly struct PartCode
    {                
        /// <summary>
        /// The owning part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The code in the set
        /// </summary>
        public readonly EncodedMembers[] Data;

        [MethodImpl(Inline)]
        public PartCode(PartId part, EncodedMembers[] src)
        {
            Part = part;
            Data = src;
        }
    }
}