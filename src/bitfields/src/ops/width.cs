//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;    
    using static Root;

    partial class BitFields
    {
        [MethodImpl(Inline)]
        public static BitFieldSpec256<F> specify<F>(W256 w)
            where F : unmanaged, Enum
        {
            Span<F> values = Enums.literals<F>();
            var widths = values.Bytes();
            var count = math.min(widths.Length, 32);
            var data = default(Vector256<byte>);
            for(var i=0; i<count; i++)
                data = data.WithElement(i,skip(widths,i));  
            return new BitFieldSpec256<F>(data);              
        }
    }
}