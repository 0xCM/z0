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
        IndexedSeq<CmdDescriptor> Data;

        [MethodImpl(Inline)]
        public CmdDescriptors(CmdDescriptor[] src)
            => Data = src;

        public Span<CmdDescriptor> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdDescriptors(CmdDescriptor[] src)
            => new CmdDescriptors(src);
    }
}