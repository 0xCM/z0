//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public static class Arrays
    {
        public static T[] alloc<T>(int length)
            => new T[length];

        public static T[] alloc<T>(int length, T fill)
        {
            var dst = alloc<T>(length);
            return dst.Fill(fill);
        }            

    }

}