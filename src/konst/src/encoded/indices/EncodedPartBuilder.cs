//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct EncodedPartBuilder : IEncodedPartBuilder
    {
        internal readonly Dictionary<MemoryAddress,MemberCode> CodeAddress;

        internal readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        internal readonly Dictionary<OpUri,MemberCode> CodeUri;

        [MethodImpl(Inline)]
        internal EncodedPartBuilder(Dictionary<MemoryAddress,MemberCode> CodeAddress, Dictionary<MemoryAddress,OpUri> UriAddress, Dictionary<OpUri,MemberCode> CodeUri)
        {            
            this.CodeAddress = CodeAddress;
            this.UriAddress = UriAddress;
            this.CodeUri = CodeUri;
        }

        public EncodedParts Freeze()
            => Encoded.freeze(this);

        public int Include(params MemberCode[] src)
            => Encoded.include(this,src);
    }
}