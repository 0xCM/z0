//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdTypeIndex : IIndex<CmdTypeInfo>
    {
        IndexedSeq<CmdTypeInfo> Data;

        [MethodImpl(Inline)]
        public CmdTypeIndex(CmdTypeInfo[] src)
            => Data = src;

        public CmdTypeInfo[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdTypeIndex(CmdTypeInfo[] src)
            => new CmdTypeIndex(src);
    }
}