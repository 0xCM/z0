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

    partial class MathSvcFactory
    {

        [MethodImpl(Inline)]
        public static BitLogicOps<T> bitlogic<T>(T t = default)
            where T : unmanaged        
                => BitLogicOps<T>.Ops;
    }
}