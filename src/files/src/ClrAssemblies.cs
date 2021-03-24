//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Root;
    using static memory;

    [ApiHost]
    public readonly struct ClrAssemblies
    {
        /// <summary>
        /// Loads an assembly + pdb
        /// </summary>
        /// <param name="image">The assembly path</param>
        /// <param name="pdb">The pdb path</param>
        [Op]
        public static Assembly load(FS.FilePath image, FS.FilePath pdb)
            => Assembly.Load(image.ReadBytes(), pdb.ReadBytes());

        [MethodImpl(Inline), Op]
        public static FS.FilePath location(ClrAssembly src)
            => FS.path(src.Definition.Location);

        [Op]
        public static ref readonly FS.FilePath xmlpath(ClrAssembly src, out FS.FilePath dst)
        {
            var candidate = FS.path(Path.ChangeExtension(src.Definition.Location, FS.Extensions.Xml.Name));
            dst = candidate.Exists ? candidate : FS.FilePath.Empty;
            return ref dst;
        }

        [Op]
        public static ref readonly FS.FilePath pdbpath(ClrAssembly src, out FS.FilePath dst)
        {
            var candidate = FS.path(Path.ChangeExtension(src.Definition.Location, FS.Extensions.Pdb.Name));
            dst = candidate.Exists ? candidate : FS.FilePath.Empty;
            return ref dst;
        }
    }
}