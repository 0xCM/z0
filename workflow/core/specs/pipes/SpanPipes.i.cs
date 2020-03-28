//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static root;

    public interface ISpanPipe<T> : IPipe
        where T : struct
    {   
        ref T Flow(ref T src);

        Span<T> Flow(Span<T> src)
        {
            for(var i=0; i<src.Length; i++)
                Flow(ref refs.seek(src, i));
            return src;
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
        {            
            ref T value = ref Unsafe.As<object,T>(ref src);
            return Flow(ref value);
        }
    }


}