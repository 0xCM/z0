//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [Cmd]
    public struct EmitResDataCmd : ICmdSpec<EmitResDataCmd>
    {
        public Assembly Source;

        public FS.FolderPath Target;

        public utf8 Match;
    }
}