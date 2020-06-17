//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly ref struct EvalContext
    {
        public readonly BufferTokens Buffers;        

        public readonly ApiMemberCode ApiCode;

        public UriHex ApiBits { [MethodImpl(Inline)] get => ApiCode.Encoded;}

        public ApiMember Member { [MethodImpl(Inline)] get =>  ApiCode.Member;}

        [MethodImpl(Inline)]
        public static EvalContext Define(BufferTokens buffers, ApiMemberCode code)
            => new EvalContext(buffers,code);

        [MethodImpl(Inline)]
        internal EvalContext(BufferTokens buffers, ApiMemberCode code)
        {
            this.Buffers = buffers;
            this.ApiCode = code;
        }        
    }
}