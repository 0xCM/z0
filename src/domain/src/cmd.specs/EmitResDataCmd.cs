//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [Cmd(Code)]
    public struct EmitResDataCmd : ICmdSpec<EmitResDataCmd>
    {
        public const string Code = CmdCodes.EmitRes;

        public Assembly Source;

        public FS.FolderPath Target;

        public string Match;

        // [MethodImpl(Inline)]
        // public EmitResDataCmd(Assembly src, FS.FolderPath dst, string filter = null)
        // {
        //     Source = src;
        //     Target = dst;
        //     Match = filter ?? EmptyString;
        // }
    }
}