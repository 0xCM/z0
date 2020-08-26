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

    public readonly struct EncodedPartBuilder
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

        public bool Include(MemberCode src)
        {
            return CodeAddress.TryAdd(src.Address, src);
        }

        public int Include(MemberCode[] src, ISink<MemberCode> duplicate)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                var code = src[i];
                if(!CodeAddress.TryAdd(code.Address, code))
                    duplicate.Deposit(code);
                else
                    count++;

                UriAddress.TryAdd(code.Address, code.OpUri);
                CodeUri.TryAdd(code.OpUri, code);
            }
            return count;
        }

    }
}