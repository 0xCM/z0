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

        ref readonly ApiModules Modules
        {
            [MethodImpl(Inline)]
            get => ref State.Modules;
        }

        public ReadOnlySpan<Assembly> Components
        {
            [MethodImpl(Inline)]
            get => Modules.Assemblies;
        }

        ref readonly ApiParts PartSet
        {
            [MethodImpl(Inline)]
            get => ref Modules.Api;
        }

        public IApiPartCatalog[] Catalogs
        {
            [MethodImpl(Inline)]
            get => PartSet.Catalogs;
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
            get => PartSet.Identifiers;
        }

        ApiContextState IStateful<ApiContextState>.State
            => State;
    }

    public readonly struct ApiContextState
    {
        internal readonly ApiModules Modules;

        [MethodImpl(Inline)]
        internal ApiContextState(in ApiModules modules)
        {
            Modules = modules;
        }
    }
}