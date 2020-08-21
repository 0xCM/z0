//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct EnvVars
    {
        public const string Dev = "ZDev";

        public const string Log = "ZLogs";

        public const string Pub = "ZArchive";

        public static Env Common
        {
            [MethodImpl(Inline)]
            get => common();
        }

        [MethodImpl(Inline), Op]
        static Env common()
        {
            var log = EnvVars.read(Log).Transform(FolderPath.Define);
            var dev = EnvVars.read(Dev).Transform(FolderPath.Define);
            var archive = EnvVars.read(Pub).Transform(FolderPath.Define);
            return new Env(log, dev,archive);
        }

        [MethodImpl(Inline), Op]
        public static EnvVar read(string name)
            => new EnvVar(name, Environment.GetEnvironmentVariable(name));

        [MethodImpl(Inline), Op]
        public static EnvVar define(string name, string value)
            => new EnvVar(name, value);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static EnvVar<T> define<T>(string name, T value)
            => new EnvVar<T>(name,value);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public EnvVar<T> map<T>(EnvVar src, Func<string,T> f)
            => define(src.Name,f(src.Value));
    }
}