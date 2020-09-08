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
    public readonly struct ContextFactory
    {
        public static IShellPaths Paths
        {
            [MethodImpl(Inline), Op]
            get => ShellPaths.Default;
        }

        [MethodImpl(Inline), Op]
        public static IAppContext app()
            => app(Paths, compose(ApiQuery.parts()), random());

        [MethodImpl(Inline), Op]
        public static IAppContext app(ApiModules src, IShellPaths paths)
            => new AppContext(paths, src.Api, random(), settings(paths), exchange());

        [MethodImpl(Inline), Op]
        static IAppContext app(IShellPaths paths, ApiParts api, IPolyrand random)
            => new AppContext(paths, api, random, settings(paths), exchange());

        [MethodImpl(Inline), Op]
        static ISettings settings(IShellPaths paths)
            => SettingValues.Load(paths.AppConfigPath);

        static AppMsgExchange exchange()
            => AppMsgExchange.Create();

        [MethodImpl(Inline), Op]
        static ApiParts compose(IPart[] parts)
            => ApiQuery.api(parts);

        [MethodImpl(Inline), Op]
        static IPolyrand random()
            => Polyrand.Pcg64(PolySeed64.Seed05);
    }
}