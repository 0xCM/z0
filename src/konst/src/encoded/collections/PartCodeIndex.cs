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
    public readonly struct PartCodeIndex
    {                
        /// <summary>
        /// The owning part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The code in the set
        /// </summary>
        public readonly MemberCodeIndex[] Data;

        [MethodImpl(Inline)]
        public PartCodeIndex(PartId part, MemberCodeIndex[] src)
        {
            Part = part;
            Data = src;
        }

        [MethodImpl(Inline)]
        PartCodeIndex(PartId part)
        {
            Part = part;
            Data = Array.Empty<MemberCodeIndex>();
        }

        public static PartCodeIndex Empty 
        {
            [MethodImpl(Inline)]
            get => new PartCodeIndex(0);
        }
    }
}