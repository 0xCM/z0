//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct z
    {
        public static T[] concat<T>(T[] a, T[] b)
        {
            var length = a.Length + b.Length;
            var dst = sys.alloc<T>(length);
            a.CopyTo(dst,0);
            b.CopyTo(dst, a.Length);
            return dst;
        }            
    }
}