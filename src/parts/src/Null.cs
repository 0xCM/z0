//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct Null : ITextual, INullaryKnown, INullary<Null>
    {
        public static Null Value => default(Null);
        
        [MethodImpl(Inline)]
        public static object Banish(object src) 
            => src ?? Value;

        [MethodImpl(Inline)]
        public static string Banish(string src)
            => src ?? "null";

        [MethodImpl(Inline)]
        public static bool Is(object src)
            => src is Null || src is null;

        [MethodImpl(Inline)]
        public static bool IsNot(object src)
            => !Is(src);

        [MethodImpl(Inline)]
        public static T Banish<T>(T src, T alt) 
            where T : class
                => src ?? alt;

        public bool IsEmpty => true;
        
        public Null Zero => Value;
        
        public string Format()
            => nameof(Null).ToLower();

        public override string ToString()
            => Format();
    }
}