//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EvalContext
    {
        public readonly BufferTokens Buffers;

        public readonly ApiMemberCode ApiCode;

        [MethodImpl(Inline)]
        public EvalContext(BufferTokens buffers, ApiMemberCode code)
        {
            Buffers = buffers;
            ApiCode = code;
        }

        public ApiCodeBlock ApiBits
        {
            [MethodImpl(Inline)]
            get => ApiCode.Encoded;
        }

        public ApiMember Member
        {
            [MethodImpl(Inline)]
            get =>  ApiCode.Member;
        }
    }
}