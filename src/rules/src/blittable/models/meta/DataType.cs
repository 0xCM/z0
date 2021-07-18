//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DataType
    {
        public TypeKind Kind {get;}

        public BitWidth ContentWidth {get;}

        public BitWidth StorageWidth {get;}

        [MethodImpl(Inline)]
        public DataType(TypeKind kind, BitWidth cwidth, BitWidth swidth)
        {
            Kind = kind;
            ContentWidth = cwidth;
            StorageWidth = swidth;
        }
    }
}