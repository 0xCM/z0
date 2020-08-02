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
    public readonly struct MemberExtractor : IMemberExtractor
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

        public ExtractedCode Extract(ApiMember src)
            => MemberExtraction.extract(src, Buffer);

        public ExtractedCode[] Extract(ApiMember[] members)
            => MemberExtraction.extract(members, Buffer);

        public ExtractedCode[] Extract(IApiHost src)
            => MemberExtraction.extract(ApiMemberJit.jit(src), Buffer);

        public ExtractedCode[] Extract(IApiHost[] src, IWfBroker broker)
            => MemberExtraction.extract(ApiMemberJit.jit(src, broker.Sink), Buffer);
    }
}