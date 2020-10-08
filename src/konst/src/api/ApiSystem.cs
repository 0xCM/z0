//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost("api.system")]
    public readonly struct ApiSystem
    {
        /// <summary>
        /// Creates a <see cref='ApiContext'/> from the entry assembly
        /// </summary>
        [Op]
        public static ApiContext context()
            => context(FS.path(Assembly.GetEntryAssembly().Location).FolderPath);

        /// <summary>
        /// Creates a <see cref='ApiContext'/> from a specified directory
        /// </summary>
        [Op]
        public static ApiContext context(FS.FolderPath src)
            => new ApiContext(new ApiContextState(new ApiPartSet(src)));

        /// <summary>
        /// Creates a <see cref='ApiContext'/> with injected state
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ApiContext context(in ApiContextState state)
            => new ApiContext(state);

        /// <summary>
        /// Creates a <see cref='ApiContext'/> over a specified set of modules
        /// </summary>
        [MethodImpl(Inline), Op]
        public static ApiContext context(in ApiPartSet src)
            => new ApiContext(new ApiContextState(src));
    }
}