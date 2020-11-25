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

    public readonly struct Toolsets
    {
        readonly Index<Toolset> Data;

        [MethodImpl(Inline)]
        internal Toolsets(Toolset[] src)
            => Data = src;

        public ref Toolset this[uint id]
        {
            [MethodImpl(Inline)]
            get => ref Data[id];
        }
    }
}