//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    public readonly struct MemberExtractor
    {
        readonly byte[] _Buffer;

        Span<byte> Buffer
        {
            [MethodImpl(Inline)]
            get
            {
                Span<byte> buffer = _Buffer;
                return sys.clear(buffer);
            }
        }

        [MethodImpl(Inline)]
        internal MemberExtractor(int bufferlen)
            => _Buffer = sys.alloc<byte>(bufferlen);

        [MethodImpl(Inline)]
        internal MemberExtractor(byte[] buffer)
            => _Buffer = buffer;

        [MethodImpl(Inline)]
        public ApiMemberExtract Extract(ApiMember src)
            => ApiCodeExtractors.extract(src, Buffer);

        [MethodImpl(Inline)]
        public ApiMemberExtract[] Extract(ApiMember[] members)
            => ApiCodeExtractors.extract(members, Buffer);
    }
}