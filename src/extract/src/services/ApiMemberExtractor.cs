//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = ApiExtracts;

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    public readonly struct ApiMemberExtractor
    {
        readonly byte[] _Buffer;

        Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get
            {
                Span<byte> buffer = _Buffer;
                return clear(buffer);
            }
        }

        [MethodImpl(Inline)]
        internal ApiMemberExtractor(byte[] buffer)
            => _Buffer = buffer;

        [MethodImpl(Inline)]
        public Index<ApiMemberExtract> Extract(ApiMember[] src)
            => api.extract(src, Buffer);
    }
}