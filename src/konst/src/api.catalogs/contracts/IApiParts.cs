//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiParts
    {
        /// <summary>
        /// The controlling assembly
        /// </summary>
        Assembly Control {get;}

        /// <summary>
        /// The root of the archive one which the api module set is predicated
        /// </summary>
        FS.FolderPath Source {get;}

        FS.Files ManagedSources {get;}

        Assembly[] PartComponents {get;}

        IGlobalApiCatalog ApiGlobal {get;}

        /// <summary>
        /// Searches for a component with a specified identity
        /// </summary>
        /// <param name="part">The part id</param>
        /// <param name="component">The corresponding component, if found</param>
        bool Component(PartId part, out Assembly component);
    }
}