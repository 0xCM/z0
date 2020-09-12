//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AspectData<T>
    {
        public T Source {get;}

        public string[] Rows {get;}

        [MethodImpl(Inline)]
        public AspectData(T src, string[] rows)
        {
            Source = src;
            Rows = rows;
        }
    }
}