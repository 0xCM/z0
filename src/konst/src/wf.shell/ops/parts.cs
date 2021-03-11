//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Part;

    partial class WfShell
    {
        [Op]
        public static ApiPartSet parts()
            => parts(WfShell.controller(), Environment.GetCommandLineArgs());

        [Op]
        public static ApiPartSet parts(Assembly control, FS.FolderPath src)
            => new ApiPartSet(control, src);

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static ApiPartSet parts(Assembly control, Index<PartId> identifiers)
        {
            if(identifiers.IsNonEmpty)
               return new ApiPartSet(control, identifiers);
            else
                return new ApiPartSet(control);
        }

        /// <summary>
        /// Creates a <see cref='ApiPartSet'/> predicated an optionally-specified <see cref='PartId'/> sequence
        /// where the entry assembly is assumed to be the locus of control
        /// </summary>
        /// <param name="control">The controlling assembly</param>
        /// <param name="identifiers">The desired parts to include, or empty to include all known parts</param>
        [Op]
        public static ApiPartSet parts(Index<PartId> identifiers)
            => parts(controller(), identifiers);

        [Op]
        public static ApiPartSet parts(Assembly control, string[] args)
        {
            if(args.Length != 0)
            {
                var identifiers = ApiPartIdParser.parse(args);
                if(identifiers.Length != 0)
                    return new ApiPartSet(control, identifiers);
            }

            return new ApiPartSet(control);
        }
    }
}