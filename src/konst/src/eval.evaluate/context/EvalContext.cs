//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EvalContext
    {
        public readonly BufferTokens Buffers;

        public readonly ApiMemberHex ApiCode;

        [MethodImpl(Inline)]
        public EvalContext(BufferTokens buffers, ApiMemberHex code)
        {
            Buffers = buffers;
            ApiCode = code;
        }

        public ApiHex ApiBits
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