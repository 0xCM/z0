//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost]
    public unsafe partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static unsafe MemoryBlock block(byte* pSrc, int length)
            => new MemoryBlock(pSrc,length);
    }
}