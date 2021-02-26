//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    [ApiComplete]
    partial struct Msg
    {
        public static MsgPattern<FS.FilePath> EmittedRuntimeIndex => "Emitted operation index to {0}";
    }
}