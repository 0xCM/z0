//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Defines a root abstraction for types that define succinct representatives of .Net artifacts
    /// </summary>
    public abstract class ClrArtifact
    {
        protected ClrArtifact(string Name, int? Id = null)
        {
            this.Name = Name;
            this.Id = Id ?? 0;
        }

        public string Name {get;}

        public int Id {get;}
        
        public virtual string Format()
            => Name.ToString();

        public override string ToString()
            => Format();
    }
}