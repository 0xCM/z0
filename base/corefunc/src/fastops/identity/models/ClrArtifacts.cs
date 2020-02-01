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

    public abstract class ClrArtifacts<S,T>
        where S : ClrArtifacts<S,T>
        where T : ClrArtifact
    {
        protected abstract IReadOnlyList<T> Items {get;}

        public virtual string Format()
            => Items.Select(x => x.Format()).Concat(", ");            
        
        public override string ToString()
            => Format();
    }
}