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
        internal readonly Dictionary<MemoryAddress,X86ApiCode> CodeAddress;

        internal readonly Dictionary<MemoryAddress,OpUri> UriAddress;

        internal readonly Dictionary<OpUri,X86ApiCode> CodeUri;

        [MethodImpl(Inline)]
        internal EncodedPartBuilder(Dictionary<MemoryAddress,X86ApiCode> codes, Dictionary<MemoryAddress,OpUri> addresses, Dictionary<OpUri,X86ApiCode> identities)
        {
            CodeAddress = codes;
            UriAddress = addresses;
            CodeUri = identities;
        }

        public EncodedParts Freeze()
            => Encoded.freeze(this);

        public bool Include(X86ApiCode src)
        {
            return CodeAddress.TryAdd(src.Address, src);
        }

        public int Include(X86ApiCode[] src, ISink<X86ApiCode> duplicate)
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