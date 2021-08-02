//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct DataType
    {
        public BlittableKind Kind {get;}

        public uint ContentWidth {get;}

        public uint StorageWidth {get;}

        [MethodImpl(Inline)]
        public DataType(BlittableKind kind, BitWidth content, BitWidth storage)
        {
            Kind = kind;
            ContentWidth = content;
            StorageWidth = storage;
        }
    }
}