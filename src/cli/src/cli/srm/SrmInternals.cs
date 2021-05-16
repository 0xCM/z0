// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Root;

    [ApiHost]
    public readonly partial struct SrmInternals
    {
        [MethodImpl(Inline), Op]
        public static StringHandle StringHandleFromOffset(int heapOffset)
            => memory.@as<uint,StringHandle>(StringHandleType.String | (uint)heapOffset);

    }
}