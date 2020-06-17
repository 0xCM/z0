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
        public static PartCode Empty => new PartCode(PartId.None, Control.array<HostCode>());        
        
        /// <summary>
        /// The owning part
        /// </summary>
        public PartId Part {get;}

        /// <summary>
        /// The code in the set
        /// </summary>
        public HostCode[] Code {get;}

        [MethodImpl(Inline)]
        public static PartCode Define(PartId part, HostCode[] code)
            => new PartCode(part, code.Where(c => c.Id.Owner == part));

        [MethodImpl(Inline)]
        public PartCode(PartId part, HostCode[] code)
        {
            Part = part;
            Code = code;
        }
    }
}