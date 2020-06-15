//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    partial struct asci
    {
        public static AsciNull Null 
            => default;
    }

    public readonly struct AsciNull
    {
        [MethodImpl(Inline)]
        public static implicit operator asci2(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator asci4(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator asci8(AsciNull src)
            => default;
        
        [MethodImpl(Inline)]
        public static implicit operator asci16(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator asci32(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator asci64(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator Null(AsciNull src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator AsciNull(Null src)
            => default;
    }
}