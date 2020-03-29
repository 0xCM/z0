//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Components;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        public static int bitsize<T>(T rep)            
            => Unsafe.SizeOf<T>()*8;
    }
}