//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var result = default(T);
                for(var i=0; i< src.Length; i++)
                    result = gmath.add(result, src[i]);
                return result;
            }
        }

        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());
    }
}