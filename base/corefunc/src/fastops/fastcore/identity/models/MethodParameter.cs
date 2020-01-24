//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// Represents a method (value, not type) parameter 
    /// </summary>
    public class MethodParameter : ClrArtifact
    {        
        public MethodParameter(TypeSig Type, ParamDirection Direction, string ParamName, int Position)
            : base(ParamName)            
        {
            this.Type = Type;
            this.Direction = Direction;
            this.Position = Position;
        }

        public TypeSig Type {get;}

        public ParamDirection Direction {get;}
        
        public int Position {get;}

        public override string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();
    }
}