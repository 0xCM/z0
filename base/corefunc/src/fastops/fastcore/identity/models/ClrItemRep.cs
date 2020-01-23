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
    /// Defines a root abstraction for types that define succinct representatives of .Net artifacts
    /// </summary>
    public abstract class ClrItemRep
    {
        protected ClrItemRep(string Name, int? Id = null)
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

    public abstract class ClrItemReps<S,T>
        where S : ClrItemReps<S,T>
        where T : ClrItemRep
    {
        protected abstract IReadOnlyList<T> Items {get;}

        public virtual string Format()
            => Items.Select(x => x.Format()).Concat(", ");            
        
        public override string ToString()
            => Format();
    }

}