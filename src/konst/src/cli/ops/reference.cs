//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cli
    {
        /// <summary>
        /// Defines an <see cref='CliArtfactRef'/> predicated on an a <see cref='ClrArtifactKey'/>
        /// </summary>
        /// <param name="src">The defining type</param>
        [MethodImpl(Inline), Op]
        public static CliArtifactRef reference(ClrArtifactKey id, ClrArtifactKind kind, StringRef name)
            => new CliArtifactRef(id,kind,name);
    }
}