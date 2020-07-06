//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiCodeEval
    {
        public readonly BufferTokens Buffers;        

        public readonly ApiCode ApiCode;

        public IdentifiedCode ApiBits 
        { 
            [MethodImpl(Inline)] 
            get => ApiCode.Encoded;
        }

        public ApiMember Member 
        { 
            [MethodImpl(Inline)] 
            get =>  ApiCode.Member;
        }

        [MethodImpl(Inline)]
        public ApiCodeEval(BufferTokens buffers, ApiCode code)
        {
            Buffers = buffers;
            ApiCode = code;
        }        
    }
}