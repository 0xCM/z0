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

    public readonly struct WfCmdOptions<K,T>
        where K : unmanaged
    {
        readonly TableSpan<WfCmdOption<K,T>> Data;

        [MethodImpl(Inline)]
        public WfCmdOptions(WfCmdOption<K,T>[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfCmdOptions<K,T>(WfCmdOption<K,T>[] src)
            => new WfCmdOptions<K,T>(src);

        public ReadOnlySpan<WfCmdOption<K,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}
