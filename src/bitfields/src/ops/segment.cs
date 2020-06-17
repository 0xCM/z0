//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    partial class BitFields
    {            
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly FieldSegment segment<T>(in BitField<T> field, int index)
            where T : unmanaged
                => ref field.Segment(index);        
    }
}