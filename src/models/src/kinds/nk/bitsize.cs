//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class NumericKinds
    {            
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;
    }
}