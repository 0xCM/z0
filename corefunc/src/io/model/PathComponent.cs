//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    
    public abstract class PathComponent<T>
        where T : PathComponent<T>
    {
        public static bool operator ==(PathComponent<T> x, PathComponent<T> y)
            => x != null && x.Equals(y);

        public static bool operator !=(PathComponent<T> x, PathComponent<T> y)
            => x != null && !x.Equals(y);

        public string Name {get;}

        protected PathComponent(string Name)
            => this.Name = Name;
        
        public override string ToString()
            => Name;
        
        public bool IsNonEmpty
            => nonempty(Name);

        public bool IsEmpty
            => ! nonempty(Name);            

        public override int GetHashCode()
            => Name.GetHashCode();
        
        public bool Equals(T src)
            => src != null && string.Compare(src.Name, Name,true) == 0;
        
        public override bool Equals(object src)
            => src is PathComponent<T> p && Equals(p);

    }

}