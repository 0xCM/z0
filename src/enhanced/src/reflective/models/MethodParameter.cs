//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents a method (value, not type) parameter 
    /// </summary>
    public readonly struct MethodParameter : ITextual
    {        
        public string Name {get;}

        public int Position {get;}

        public TypeSig Type {get;}

        public ParamRefKind RefKind {get;}

        public MethodParameter(TypeSig sig, ParamRefKind refkind, string name, int position)
        {
            Type = sig;
            Name = name;
            Position = position;
            RefKind = refkind;
        }
        
        public string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();
    }
}