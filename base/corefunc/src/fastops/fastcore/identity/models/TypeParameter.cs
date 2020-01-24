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
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public class TypeParameter : ClrArtifact
    {
        public TypeParameter(string Name, int Position, bool IsOpen = true)
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
            => fence ? angled(Name) : Name;

        public override string Format()
            => Format(false);
    }

}