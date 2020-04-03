//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using TK = FixedTypes;

    public static partial class FixedType
    {
        [MethodImpl(Inline)]
        public static FixedKind kind<W>(W w = default)
            where W : unmanaged, ITypeWidth
        {
            if(typeof(W) == typeof(W16))
                return FixedKind.Fixed16;
            else if(typeof(W) == typeof(W32))
                return FixedKind.Fixed32;
            else if(typeof(W) == typeof(W64))
                return FixedKind.Fixed64;
            else if(typeof(W) == typeof(W128))
                return FixedKind.Fixed128;
            else if(typeof(W) == typeof(W256))
                return FixedKind.Fixed256;
            else if(typeof(W) == typeof(W512))
                return FixedKind.Fixed512;
            else
                return 0;
        }

        public static TK.Fixed8 Fixed8
            => default;

        public static TK.Fixed16 Fixed16
            => default;

        public static TK.Fixed32 Fixed32
            => default;

        public static TK.Fixed64 Fixed64
            => default;

        public static TK.Fixed128 Fixed128
            => default;

        public static TK.Fixed256 Fixed256
            => default;

        public static TK.Fixed512 Fixed512
            => default;    
    }
}