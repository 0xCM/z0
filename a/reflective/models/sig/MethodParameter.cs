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
    public class MethodParameter : SigArtifact
    {        
        public MethodParameter(TypeSig Type, ParamRefKind Variance, string ParamName, int Position)
            : base(ParamName)            
        {
            this.Type = Type;
            this.Variance = Variance;
            this.Position = Position;
        }

        public TypeSig Type {get;}

        public ParamRefKind Variance {get;}
        
        public int Position {get;}

        public override string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();
    }
}