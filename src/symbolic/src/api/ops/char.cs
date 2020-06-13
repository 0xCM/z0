//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static char @char(UpperCased @case, HexDigit digit)
            => (char)code(@case, digit);

        [MethodImpl(Inline), Op]
        public static char @char(LowerCased @case, HexDigit digit)
            => (char)code(@case, digit);

        [MethodImpl(Inline)]
        public static char @char<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat         
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S,T>(Symbol<S,T> src)
            where S : unmanaged
            where T : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));

        [MethodImpl(Inline)]
        public static char @char<S>(Symbol<S> src)
            where S : unmanaged
                => Unsafe.As<S,char>(ref edit(src.Value));
    }
}