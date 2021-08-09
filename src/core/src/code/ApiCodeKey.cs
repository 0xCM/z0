//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)StorageSize), Blittable(StorageSize)]
    public readonly struct ApiCodeKey
    {
        public const uint StorageSize = ApiHostKey.StorageSize + PrimalSizes.U32;

        public ApiHostKey HostKey {get;}

        public uint BlockSeq {get;}

        [MethodImpl(Inline)]
        public ApiCodeKey(ApiHostKey host, uint block)
        {
            HostKey = host;
            BlockSeq = block;
        }

        public string Format()
            => string.Format("f_{0}_{1}_{2}", (byte)HostKey.Part, HostKey.HostSeq, BlockSeq);

        public override string ToString()
            => Format();
    }
}