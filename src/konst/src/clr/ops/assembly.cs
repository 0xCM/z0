//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        /// <summary>
        /// Loads an assembly + pdb
        /// </summary>
        /// <param name="image">The assembly path</param>
        /// <param name="pdb">The pdb path</param>
        [Op]
        public static Assembly assembly(FS.FilePath image, FS.FilePath pdb)
            => Assembly.Load(image.ReadBytes(), pdb.ReadBytes());
    }
}