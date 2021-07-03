//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Inst<T>
        where T : unmanaged
    {
        public T Encoded {get;}

        [MethodImpl(Inline)]
        public Inst(T src)
        {
            Encoded = src;
        }
    }
}