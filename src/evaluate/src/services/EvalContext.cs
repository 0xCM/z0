//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly ref struct EvalContext
    {
        public readonly BufferTokens Buffers;        

        public readonly MemberCode ApiCode;

        public UriBits ApiBits { [MethodImpl(Inline)] get => ApiCode.Encoded;}

        public Member Member { [MethodImpl(Inline)] get =>  ApiCode.Member;}

        [MethodImpl(Inline)]
        public static EvalContext Define(BufferTokens buffers, MemberCode code)
            => new EvalContext(buffers,code);

        [MethodImpl(Inline)]
        internal EvalContext(BufferTokens buffers, MemberCode code)
        {
            this.Buffers = buffers;
            this.ApiCode = code;
        }        
    }
}