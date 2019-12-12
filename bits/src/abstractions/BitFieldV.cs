//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static AsIn;
    
    /// <summary>
    /// Defines a segmented bitfield indexed by enum values
    /// </summary>
    /// <remarks>
    /// The literals must define a dense monotonically increasing sequence within the integral range [0,31]. 
    /// In other words, there must be a bijection between the enum values and some subsequence s_k that satisifies
    /// s_i < s_{i + 1}  and s_m == s_n <=> m == n. The easiest way to satisfy these criteria is to simply
    /// create an enum where the first literal has the value 0, the second literal has the value 1 and so
    /// on as needed up to the maximum of 32 literals/values
    /// </remarks>
    public struct BitField<E>
        where E : unmanaged, Enum
    {        
        internal Vector256<byte> widths;
            
        [MethodImpl(Inline)]
        internal BitField(Vector256<byte> widths)
            => this.widths = widths;

        /// <summary>
        /// Gets the width of an identified field
        /// </summary>
        public byte this [E field]
        {
            [MethodImpl(Inline)]
            get => BitField.getwidth(widths,field);
        }    
    }
}