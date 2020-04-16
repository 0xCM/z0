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
        public readonly BufferSeq Buffers;        

        public readonly ApiMemberCode ApiCode;

        [MethodImpl(Inline)]
        public static EvalContext Define(in BufferSeq buffers, in ApiMemberCode code)
            => new EvalContext(buffers,code);

        [MethodImpl(Inline)]
        EvalContext(in BufferSeq buffers, in ApiMemberCode code)
        {
            this.Buffers = buffers;
            this.ApiCode = code;
        }        
    }
}