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

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost("reflex.artifacts")]
    public readonly partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static ClrTypeCodes TypeCodes()
            => ClrTypeCodes.cached();
    }
}