//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BasedApiMembers
    {
        public MemoryAddress Base {get;}

        public ApiMembers Members {get;}

        [MethodImpl(Inline)]
        public BasedApiMembers(MemoryAddress @base, ApiMembers members)
        {
            Base = @base;
            Members = members;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => Members.Count;
        }
    }
}