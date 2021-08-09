//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)StorageSize), Blittable(StorageSize)]
    public readonly struct ApiHostKey
    {
        public const uint StorageSize = PrimalSizes.U8 + PrimalSizes.U32;

        public PartId Part {get;}

        public uint HostSeq {get;}

        [MethodImpl(Inline)]
        public ApiHostKey(PartId part, uint seq)
        {
            Part = part;
            HostSeq = seq;
        }

        public static ApiHostKey Empty => default;
    }
}