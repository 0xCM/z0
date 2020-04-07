//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class gbits
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T parse<T>(ReadOnlySpan<char> src, int offset, out T dst)
            where T : unmanaged
        {            
            var last = math.min(bitsize<T>(), src.Length) - 1;
            ref readonly var input = ref head(src);            
            dst = default;

            for(int i=offset, pos = 0; i<= last; i++, pos++)
                if(skip(input,i) == bit.One)
                    dst = gbits.enable(dst, pos);                        
            return ref dst;
        }
    }
}