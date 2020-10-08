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

    public struct ApiContext : IApiContext<ApiContext, ApiContextState>
    {
        ApiContextState[] Data;

        ref ApiContextState State
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        [MethodImpl(Inline)]
        internal ApiContext(in ApiContextState src)
            => Data = new ApiContextState[1]{src};

        ref readonly ApiPartSet Modules
        {
            [MethodImpl(Inline)]
            get => ref State.Modules;
        }

        public ReadOnlySpan<Assembly> Components
        {
            [MethodImpl(Inline)]
            get => Modules.Assemblies;
        }

        ref readonly SystemApiCatalog SystemCatalog
        {
            [MethodImpl(Inline)]
            get => ref Modules.Api;
        }

        public IApiPartCatalog[] PartCatalogs
        {
            [MethodImpl(Inline)]
            get => SystemCatalog.Catalogs;
        }

        public FS.FolderPath ModuleRoot
        {
            [MethodImpl(Inline)]
            get => Modules.Root;
        }

        public ref readonly FS.Files ManagedSources
        {
            [MethodImpl(Inline)]
            get => ref Modules.ManagedSources;
        }

        public PartId[] PartIdentifiers
        {
            [MethodImpl(Inline)]
            get => SystemCatalog.Identifiers;
        }

        ApiContextState IStateful<ApiContextState>.State
            => State;
    }
}