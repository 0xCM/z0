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

        [MethodImpl(Inline)]
        public static EvalContext Define(BufferTokens buffers, in MemberCode code)
            => new EvalContext(buffers,code);

        [MethodImpl(Inline)]
        EvalContext(BufferTokens buffers, in MemberCode code)
        {
            this.Buffers = buffers;
            this.ApiCode = code;
        }        
    }
}