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
        public void Parse(CmdLine src)
        {
            var data = src.Content;
            Id = Cmd.id(data.LeftOfFirst(Chars.Space));
        }

        ref CmdArg Current
        {
            [MethodImpl(Inline)]
            get => ref Args[Pos];
        }

        [MethodImpl(Inline)]
        CmdSpec CreateSpec()
            => Pos != 0
            ? new CmdSpec(Id, Args.Terms.Slice(0, Pos).ToArray())
            : new CmdSpec(Id);

        public CmdSpec Result
        {
            [MethodImpl(Inline)]
            get => CreateSpec();
        }
    }
}