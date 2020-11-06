//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdModels
    {
        IndexedSeq<CmdModel> Data;

        [MethodImpl(Inline)]
        public CmdModels(CmdModel[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdModels(CmdModel[] src)
            => new CmdModels(src);

        public Span<CmdModel> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }
    }
}