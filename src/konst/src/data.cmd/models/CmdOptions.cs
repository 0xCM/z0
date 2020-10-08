//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdOptions<K,T>
        where K : unmanaged
    {
        readonly TableSpan<CmdOption<K,T>> Data;

        [MethodImpl(Inline)]
        public CmdOptions(CmdOption<K,T>[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdOptions<K,T>(CmdOption<K,T>[] src)
            => new CmdOptions<K,T>(src);

        public ReadOnlySpan<CmdOption<K,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}
