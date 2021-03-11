//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static memory;

    /// <summary>
    /// Associates a collection of components along with a<see cref = 'IGlobalApiCatalog'/>
    /// </summary>
    public readonly struct ApiPartSet : IApiParts
    {
        /// <summary>
        /// The controlling assembly
        /// </summary>
        public Assembly Control {get;}

        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        public FS.FolderPath Source {get;}

        public FS.Files ManagedSources {get;}

        public Assembly[] PartComponents {get;}

        public IGlobalApiCatalog ApiGlobal {get;}

        public ApiPartSet(Assembly control, FS.FolderPath src)
        {
            Control = control;
            Source = src;
            ManagedSources = src.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            PartComponents = WfShell.components(ManagedSources);
            ApiGlobal = ApiCatalogs.GlobalCatalog(ManagedSources);
        }

        public ApiPartSet(Assembly control, PartId[] parts)
        {
            Control = control;
            Source = FS.path(control.Location).FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiGlobal = ApiCatalogs.GlobalCatalog(control, parts);
            PartComponents = ApiGlobal.PartComponents;
        }

        public ApiPartSet(Assembly control)
        {
            Control = control;
            Source = FS.path(control.Location).FolderPath;
            ManagedSources = Source.Exclude("System.Private.CoreLib").Where(f => FS.managed(f));
            ApiGlobal =  ApiCatalogs.GlobalCatalog(ManagedSources);
            PartComponents = ApiGlobal.PartComponents;
        }

        public bool Component(PartId part, out Assembly component)
        {
            var components = @readonly(PartComponents);
            var count = PartComponents.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(components,i);
                if(candidate.Id() == part)
                {
                    component = candidate;
                    return true;
                }
            }
            component = default;
            return false;
        }
    }
}