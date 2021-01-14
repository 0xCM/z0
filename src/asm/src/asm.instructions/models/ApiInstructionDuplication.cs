//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct ApiInstructionDuplication
    {
        public uint DuplicateCount {get;}

        public uint UniqueCount {get;}

        [MethodImpl(Inline)]
        public ApiInstructionDuplication(uint unique, uint dupes)
        {
            DuplicateCount = dupes;
            UniqueCount = unique;
        }
    }
}