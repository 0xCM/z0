//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public readonly struct TypeParameter : IFormattable<TypeParameter>
    {    
        public string Name {get;}

        public int Position {get;}

        [MethodImpl(Inline)]
        internal TypeParameter(string Name, int Position)
        {
            this.Name = Name;
            this.Position = Position;
        }

        public string Format(bool fence)
            => fence ? Reflective.angled(Name) : Name;

        public string Format()
            => Format(false);

        public override string ToString()
            => Format();
    }
}