//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ApiMemberAsm
    {
        public OpUri MemberId {get;}

        public MemoryAddress BaseAddress {get;}

        public Index<ApiAsmLine> Lines {get;}

        [MethodImpl(Inline)]
        public ApiMemberAsm(OpUri id, MemoryAddress @base, Index<ApiAsmLine> lines)
        {
            MemberId = id;
            BaseAddress = @base;
            Lines = lines;
        }
    }
}