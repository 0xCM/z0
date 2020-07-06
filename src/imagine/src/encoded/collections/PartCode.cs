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
        public PartId Part {get;}

        /// <summary>
        /// The code in the set
        /// </summary>
        public HostCodeIndex[] Code {get;}

        [MethodImpl(Inline)]
        public PartCodeIndex(PartId part, HostCodeIndex[] code)
        {
            Part = part;
            Code = code;
        }

        public static PartCodeIndex Empty 
            => new PartCodeIndex(PartId.None, Array.Empty<HostCodeIndex>());
    }
}