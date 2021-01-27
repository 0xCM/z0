//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
                return memory.clear(buffer);
            }
        }

        [MethodImpl(Inline)]
        internal ApiMemberExtractor(int bufferlen)
            => _Buffer = memory.alloc<byte>(bufferlen);

        [MethodImpl(Inline)]
        public ApiMemberExtract Extract(ApiMember src)
            => ApiCodeExtractors.extract(src, Buffer);

        [MethodImpl(Inline)]
        public ApiMemberExtract[] Extract(ApiMember[] members)
            => ApiCodeExtractors.extract(members, Buffer);
    }
}