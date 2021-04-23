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
        internal ApiMemberExtractor(int bufferlen)
            => _Buffer = alloc<byte>(bufferlen);

        [MethodImpl(Inline)]
        public Index<ApiMemberExtract> Extract(ApiMember[] members)
            => ApiCodeExtractors.extract(members, Buffer);
    }
}