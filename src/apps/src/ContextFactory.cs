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
        public static ApiParts KnownParts
        {
            [MethodImpl(Inline), Op]
            get => ApiQuery.Known;
        }

        public static IAppPaths Paths
        {
            [MethodImpl(Inline), Op]
            get => AppPaths.Default;
        }

        [MethodImpl(Inline), Op]
        public static IAppContext create()
            => create(Paths, compose(KnownParts), random());

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppPaths paths)
            => create(paths, compose(KnownParts), random());

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppPaths paths, IResolvedApi api)
            => new AppContext(paths, api, random(), settings(paths), exchange());

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppPaths paths, IResolvedApi api, IPolyrand random)
            => new AppContext(paths, api, random, settings(paths), exchange());

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppSettings settings, IResolvedApi api, IAppMsgQueue queue, IPolyrand random)
            => new AppContext(api, random, settings, queue);

        public static IAppContext create(IAppSettings settings, IAppPaths paths, IResolvedApi api, IAppMsgQueue queue, IPolyrand random)
            => new AppContext(paths, api, random, settings, queue);

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppPaths paths, ApiPart api)
            => create(paths, api, random());

        [MethodImpl(Inline), Op]
        public static IAppContext create(IAppPaths paths, IPart[] parts)
            => create(paths, compose(parts), random());

        [MethodImpl(Inline), Op]
        public static IAppSettings settings(IAppPaths paths)
            => AppSettings.Load(paths.AppConfigPath);

        /// <summary>
        /// Creates an exchange over an existing queue
        /// </summary>
        [MethodImpl(Inline), Op]
        public static AppMsgExchange exchange(IAppMsgQueue queue)
            => new AppMsgExchange(queue);

        static AppMsgExchange exchange()
            => AppMsgExchange.Create();

        [MethodImpl(Inline), Op]
        public static ApiPart compose(IPart[] parts)
            => ApiQuery.assemble(parts);

        [MethodImpl(Inline), Op]
        static IPolyrand random()
            => Polyrand.Pcg64(PolySeed64.Seed05);
    }
}