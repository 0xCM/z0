//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static root;
    using static VCore;

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
    public struct BitFieldSpec256x8<I>
        where I : unmanaged, Enum
    {        
        const int MaxFieldCount = 32;

        internal Vector256<byte> widths;
            
        [MethodImpl(Inline)]
        internal BitFieldSpec256x8(Vector256<byte> widths)
        {
            this.widths = widths;
        }

        [MethodImpl(Inline)]
        public byte SegWidth(I id)
            => vcell(widths, Enums.numeric<I,int>(id));

        // FieldSegment[] Segments()
        // {
        //     Span<FieldSegment> parts = alloc<FieldSegment>(MaxFieldCount);
        //     var count = 0;
        //     var start = 0;
        //     var index = FieldIndex.Create<I>().Entries;
        //     for(int i=0; i < MaxFieldCount; i++)
        //     {
        //         var width = vcell(widths,i);
        //         if(width == 0)
        //             break;                

        //         var seg = BitFields.segment(index[i].FieldName, evalue<I,byte>(index[i].FieldWidth), (byte)start, (byte)(start + width), width);
        //         parts[count++] = seg;
        //         start = start + width + 1;
        //     }
        //     return parts.Slice(0,count).ToArray();
        // }
    }
}