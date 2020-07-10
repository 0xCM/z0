//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]        
        public static uint size<T>()
            => (uint)SizeOf<T>();

        [MethodImpl(Inline)]
        public static uint size<T>(uint count)
            => (uint)SizeOf<T>() * count;

        [MethodImpl(Inline), Op]
        public static uint size(string src)
            => (uint)src.Length*scale<char>();
    }
}