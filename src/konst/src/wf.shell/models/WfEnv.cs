//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct WfEnv
    {
        [MethodImpl(Inline), Op]
        public static FS.FolderPath dbRoot()
            => EnvVars.Common.DbRoot;

        [MethodImpl(Inline), Op]
        public static string[] args()
            => Environment.GetCommandLineArgs();

        [MethodImpl(Inline), Op]
        public static Assembly entry()
            => Assembly.GetEntryAssembly();
    }
}