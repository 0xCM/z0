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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static S.BinaryOp<T> ToBinaryOp<T>(this S.Func<T,T,T> src)
            => S.binary(src.Subject.ToBinaryOp(), src.Id);
    }

}