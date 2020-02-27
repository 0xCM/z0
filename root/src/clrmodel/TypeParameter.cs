//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public class TypeParameter : ClrArtifact
    {
        public static TypeParameter Define(string name, int pos, bool open)
            => new TypeParameter(name,pos,open);
        
        TypeParameter(string Name, int Position, bool IsOpen)
            : base(Name, 0)
        {
            this.Position = Position;
            this.IsOpen = IsOpen;
            this.IsClosed = !IsOpen;
        }

        public int Position {get;}

        public bool IsOpen {get;}

        public bool IsClosed {get;}

        public string Format(bool fence)
            => fence ? text.angled(Name) : Name;

        public override string Format()
            => Format(false);
    }
}