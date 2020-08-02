//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Named : INamed<Named>
    {
        public StringRef Name {get;}
        
        [MethodImpl(Inline)]
        public static Named From(string src)
            => new Named(src);
        
        [MethodImpl(Inline)]
        public static implicit operator string(Named src)
            => src.Name;

        [MethodImpl(Inline)]
        public static implicit operator Named(string src)
            => From(src);

        [MethodImpl(Inline)]
        public Named(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name; 
    }    
}