//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = Surrogates;

    partial class SFXTend
    {
        [MethodImpl(Inline)]
        public static S.Emitter<T> ToEmitter<T>(this S.Func<T> src)
            => S.emitter(src.Subject.ToEmitter(), src.Id);
    }
}