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
        public X86ApiExtract Extract(ApiMember src)
            => MemberExtraction.extract(src, Buffer);

        [MethodImpl(Inline)]
        public X86ApiExtract[] Extract(ApiMember[] members)
            => MemberExtraction.extract(members, Buffer);

        [MethodImpl(Inline)]
        public X86ApiExtract[] Extract(IApiHost src, IWfBroker broker)
            => MemberExtraction.extract(ApiMemberJit.jit(src), Buffer);

        [MethodImpl(Inline)]
        public X86ApiExtract[] Extract(IApiHost[] src, IWfBroker broker)
            => MemberExtraction.extract(ApiMemberJit.jit(src, broker.Sink), Buffer);
    }
}