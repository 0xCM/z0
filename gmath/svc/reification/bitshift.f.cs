//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static SFuncs;
    using static MathSvcHosts;

    partial class MathServices
    {
        [MethodImpl(Inline)]
        public static Sll<T> sll<T>(T t = default)
            where T : unmanaged        
                => Sll<T>.Op;

        [MethodImpl(Inline)]
        public static Srl<T> srl<T>(T t = default)
            where T : unmanaged        
                => Srl<T>.Op;

        [MethodImpl(Inline)]
        public static MathSvcHosts.Parse<T> parse<T>(T t = default)
            where T : unmanaged        
                => MathSvcHosts.Parse<T>.Op;
    }
}