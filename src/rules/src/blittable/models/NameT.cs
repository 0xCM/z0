//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Name<T>
        where T : unmanaged
    {
        public T Storage {get;}

        [MethodImpl(Inline)]
        public Name(T data)
        {
            Storage= data;
        }
    }
}