//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Environs
    {
        public static Env Common
        {
            [MethodImpl(Inline)]
            get => Env.create();
        }

        [Op]
        public static FS.FolderPath dbRoot()
        {
            var path = Environs.Common.DbRoot;
            if(path.IsEmpty)
                root.@throw("The DbRoot environment variable is unspecified");
            return path;
        }

        [MethodImpl(Inline), Op]
        public static string[] args()
            => Environment.GetCommandLineArgs();

        [MethodImpl(Inline), Op]
        public static EnvVar define(string name, string value)
            => new EnvVar(name, value);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static EnvVar<T> define<T>(string name, T value)
            => new EnvVar<T>(name,value);
    }
}