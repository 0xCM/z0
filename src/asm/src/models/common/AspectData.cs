//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AspectData<T>
        where T : class
    {
        public T Source {get;}

        public string[] Rows {get;}

        public AspectData(T src, string[] rows)
        {
            Source = src;
            Rows = rows;
        }
    }
}