//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct Substitution<T>
    {
        public T Replace {get;}

        public T Replacement {get;}

        [MethodImpl(Inline)]
        public Substitution(T src, T dst)
        {
            Replace = src;
            Replacement = dst;
        }
    }


}