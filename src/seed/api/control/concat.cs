//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Root
    {
        public static T[] concat<T>(T[] a, T[] b)
        {
            var dst = new T[a.Length + b.Length];
            a.CopyTo(dst,0);
            b.CopyTo(dst,a.Length);
            return dst;
        }            
    }
}