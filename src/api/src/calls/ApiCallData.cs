//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [StructLayout(LayoutKind.Sequential)]
    public ref struct ApiCallData
    {
        public ApiKey Api {get;}

        public ReadOnlySpan<byte> Bytes {get;}

        [MethodImpl(Inline)]
        internal ApiCallData(ApiKey api, ReadOnlySpan<byte> src)
        {
            Bytes = src;
            Api = api;
        }
    }
}