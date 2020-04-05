//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static Seed;
    using S = Surrogates;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static S.Emitter<T> ToEmitter<T>(this S.Func<T> src)
            => S.emitter(src.Subject.ToEmitter(), src.Id);
    }
}