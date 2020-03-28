//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class root
    {                
        [MethodImpl(Inline)]
        public static TheEmpty empty() 
            => TheEmpty.The;

        [MethodImpl(Inline)]
        public static TheEmpty<T> empty<T>(T zero = default) 
            => TheEmpty<T>.The(zero);
    }
}