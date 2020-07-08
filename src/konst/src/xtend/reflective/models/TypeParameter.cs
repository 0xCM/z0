//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    /// <summary>
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public readonly struct TypeParameter : ITextual<TypeParameter>
    {    
        public string Name {get;}

        public int Position {get;}

        [MethodImpl(Inline)]
        public TypeParameter(string name, int position)
        {
            Name = name;
            Position = position;
        }

        public string Format(bool fence)
            => fence ? Name.Angled() : Name;
        
        public string Format()
            => Format(false);

        public override string ToString()
            => Format();
    }
}