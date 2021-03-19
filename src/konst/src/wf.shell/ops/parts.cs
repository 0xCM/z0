//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial class WfShell
    {
        [Op]
        public static IApiParts parts()
            => parts(WfShell.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static IApiParts parts(FS.FolderPath src)
            => new ApiPartSet(src);

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiPartSet(FS.path(control.Location).FolderPath, identifiers);
            else
                return new ApiPartSet(FS.path(control.Location).FolderPath);
        }

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static IApiParts parts(Index<PartId> identifiers)
            => parts(controller(), identifiers);

        [Op]
        public static IApiParts parts(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiPartSet(FS.path(control.Location).FolderPath, identifiers);
            }

            return new ApiPartSet(FS.path(control.Location).FolderPath);
        }
    }
}