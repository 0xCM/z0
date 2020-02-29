//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static Root;
    
    public abstract class PathComponent<T> : IIdentity<T>
        where T : PathComponent<T>, new()
    {
        public static T Empty => new T();

        public string Name {get;}

        protected PathComponent(string name)
            => this.Name = text.denullify(name);

        protected PathComponent()
            => this.Name = text.blank;

        public static bool operator ==(PathComponent<T> x, PathComponent<T> y)
            => x is T a && y is T b && a.Equals(b);

        public static bool operator !=(PathComponent<T> x, PathComponent<T> y)
            => !(x is T a && y is T b && a.Equals(b));

        public string Format()
            => Name;
        
        public bool IsNonEmpty
            => text.nonempty(Name);

        public bool IsEmpty
            => text.empty(Name);

        string IIdentity.Identifier => Name;

        public bool Equals(T src)
            => notnull(src) && string.Compare(src.Name, this.Name, true) == 0;
        
        public int CompareTo(T other)
            => Name.CompareTo(other?.Name ?? string.Empty);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()        
            => Name.GetHashCode();

        public override bool Equals(object src)
            => src is T p && Equals(p);

        public int CompareTo(IIdentity src)
            => src is T p ? CompareTo(p) : -1;
    }
}