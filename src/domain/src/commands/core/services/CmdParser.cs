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


    public struct CmdParser
    {
        CmdId Id;

        uint5 Pos;

        IndexedSeq<uint5,CmdArg> Args;

        public static CmdParser create()
            => new CmdParser(uint5.Count);

        [MethodImpl(Inline)]
        CmdParser(uint5 args)
        {
            Id = CmdId.Empty;
            Args = alloc<CmdArg>(args);
            Pos = 0;
        }

        [MethodImpl(Inline)]
        public CmdSpec Parse(CmdLine src)
        {
            return default;
        }

        ref CmdArg Current
        {
            [MethodImpl(Inline)]
            get => ref Args[Pos];
        }
    }

}