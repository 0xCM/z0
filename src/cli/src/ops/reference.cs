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
    using static z;

    partial struct Cli
    {
        /// <summary>
        /// Defines an <see cref='CliArtfactRef'/> predicated on an a <see cref='CliToken'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static CliArtifactRef reference(CliToken id, ClrArtifactKind kind, StringRef name)
            => new CliArtifactRef(id,kind,name);
    }
}