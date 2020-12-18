//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct AppCmdNames
    {
        public const string ShowVerbs = ShowVerbsCmd.CmdName;

        public const string ShowConfig = ShowConfigCmd.CmdName;

        public static ClrFieldValues<string> index()
            => ClrQuery.literals<string>(typeof(AppCmdNames));
    }
}