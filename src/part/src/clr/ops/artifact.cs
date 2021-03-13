//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Clr
    {
        /// <summary>
        /// Defines a <see cref='ClrArtfactRef'/>
        /// </summary>
        /// <param name="token"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        [MethodImpl(Inline), Op]
        public static ClrArtifactRef artifact(ClrToken token, ClrArtifactKind kind, Name name)
            => new ClrArtifactRef(token, kind, name);
    }
}