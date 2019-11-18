//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class PrimalKinds
    {                
        [MethodImpl(Inline)]
        public static PrimalKind kind<T>()
            => PrimalKind<T>.Kind;
    }
}