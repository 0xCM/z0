//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct DataType
    {
        public TypeKind Kind {get;}

        public uint ContentWidth {get;}

        public uint StorageWidth {get;}

        [MethodImpl(Inline)]
        public DataType(TypeKind kind, BitWidth cwidth, BitWidth swidth)
        {
            Kind = kind;
            ContentWidth = cwidth;
            StorageWidth = swidth;
        }
    }
}