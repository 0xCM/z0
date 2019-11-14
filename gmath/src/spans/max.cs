//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {

        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {

            if(src.IsEmpty)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(gmath.gt(src[i], result))
                    result = src[i];
            
            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(Span<T> src)
            where T : unmanaged
                => max(src.ReadOnly());

    }
}