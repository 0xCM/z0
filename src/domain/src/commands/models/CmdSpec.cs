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

    using api = Cmd;

    public struct CmdSpecData
    {
        public CmdId Id;

        public CmdOptions Options;
    }

    public readonly struct CmdSpec
    {
        internal readonly CmdOption[] OptionStorage;

        public CmdId Id {get;}

        public Span<CmdOption> Options
        {
            [MethodImpl(Inline)]
            get => OptionStorage;
        }

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdOption[] options)
        {
            Id = id;
            OptionStorage = options;
        }

        public CmdSpecData Data
        {
            [MethodImpl(Inline)]
            get => api.data(this);
        }
    }
}