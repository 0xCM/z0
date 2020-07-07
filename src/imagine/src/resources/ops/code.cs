//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Resources
    {
        /// <summary>
        /// Collects all resource accessors defined by a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [Op]
        public static CodeResourceIndex code(Assembly src)    
            => new CodeResourceIndex(src, declarations(src));

        [Op]
        public static CodeResourceIndex code(FilePath src)
            => code(Assembly.LoadFrom(src.Name));
    }
}