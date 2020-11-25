//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdDescriptors
    {
        IndexedSeq<CmdTypeInfo> Data;

        [MethodImpl(Inline)]
        public CmdDescriptors(CmdTypeInfo[] src)
            => Data = src;

        public Span<CmdTypeInfo> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdDescriptors(CmdTypeInfo[] src)
            => new CmdDescriptors(src);
    }
}