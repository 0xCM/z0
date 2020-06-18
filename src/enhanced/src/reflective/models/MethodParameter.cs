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
    public readonly struct MethodParameter : ITextual<MethodParameter>
    {        
        public string Name {get;}

        public int Position {get;}

        public TypeSig Type {get;}

        public ParamRefKind Variance {get;}

        public MethodParameter(TypeSig Type, ParamRefKind Variance, string ParamName, int Position)
        {
            this.Name = ParamName;
            this.Position = Position;
            this.Type = Type;
            this.Variance = Variance;
        }
        
        public string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();
    }
}