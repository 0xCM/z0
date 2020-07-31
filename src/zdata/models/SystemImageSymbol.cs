//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct SystemImageSymbol
    {
        public readonly string Name;

        public readonly string Identifier;        
        
        [MethodImpl(Inline)]
        public SystemImageSymbol(string name, string identifier)
        {
            Name = name;
            Identifier = identifier;
        }
    }
}