//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct EncodedIndexBuilder : IEncodedIndexBuilder
    {
        internal readonly Dictionary<MemoryAddress,MemberCode> CodeAddress;

        internal readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        internal readonly Dictionary<OpUri,MemberCode> CodeUri;

        [MethodImpl(Inline)]
        internal EncodedIndexBuilder(Dictionary<MemoryAddress,MemberCode> CodeAddress, Dictionary<MemoryAddress,OpUri> UriAddress, Dictionary<OpUri,MemberCode> CodeUri)
        {            
            this.CodeAddress = CodeAddress;
            this.UriAddress = UriAddress;
            this.CodeUri = CodeUri;
        }

        public EncodedIndex Freeze()
            => Encoded.freeze(this);

        public int Include(params MemberCode[] src)
            => Encoded.include(this,src);
    }
}