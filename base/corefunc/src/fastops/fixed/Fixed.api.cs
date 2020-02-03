//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public static partial class Fixed
    {
    
        [MethodImpl(Inline)]
        public static FixedSeg<F,T> segmented<F,T>(F value, HK.Numeric<T> k = default)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => new FixedSeg<F, T>(value);            
    }

}