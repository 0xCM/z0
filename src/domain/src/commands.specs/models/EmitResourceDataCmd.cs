//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [Cmd]
    public struct EmitResourceDataCmd : ICmdSpec<EmitResourceDataCmd>
    {
        public Assembly Source;

        public FS.FolderPath Target;

        public utf8 Match;

        public bool ClearTarget;
    }
}