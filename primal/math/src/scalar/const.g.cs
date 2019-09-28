//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static Constants;
    
    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static T one<T>()
            where T : unmanaged
                => PrimalInfo.one<T>();

        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : unmanaged
                => PrimalInfo.minval<T>();

        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : unmanaged
                => PrimalInfo.maxval<T>();
    }
}