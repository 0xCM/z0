//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;
    using static GXTypes;

    partial class GX
    {
        [MethodImpl(Inline)]
        public static Sll<T> sll<T>(T t = default)
            where T : unmanaged        
                => Sll<T>.Op;

        [MethodImpl(Inline)]
        public static Srl<T> srl<T>(T t = default)
            where T : unmanaged        
                => Srl<T>.Op;

        [MethodImpl(Inline)]
        public static GXTypes.Parse<T> parse<T>(T t = default)
            where T : unmanaged        
                => GXTypes.Parse<T>.Op;
    }

}