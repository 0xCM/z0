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

    public readonly struct CmdSpec
    {
        public CmdId Id {get;}


        public CmdOption[] Options {get;}

        [MethodImpl(Inline)]
        public CmdSpec(CmdId id, params CmdOption[] options)
        {
            Id = id;
            Options = options;
        }
    }

}