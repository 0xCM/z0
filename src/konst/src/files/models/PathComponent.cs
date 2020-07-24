//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class PathComponent<T> : IIdentification<T>
        where T : PathComponent<T>, new()
    {    
        public static T Empty => new T();

        public string Name {get;}

        protected PathComponent(string name)
            => this.Name = name ?? string.Empty;

        protected PathComponent()
            => this.Name = string.Empty;

        public static bool operator ==(PathComponent<T> x, PathComponent<T> y)
            => x is T a && y is T b && a.Equals(b);

        public static bool operator !=(PathComponent<T> x, PathComponent<T> y)
            => !(x is T a && y is T b && a.Equals(b));

        public string Format()
            => Name;
        
        public bool IsNonEmpty
            => !string.IsNullOrWhiteSpace(Name);

        public bool IsEmpty
            => string.IsNullOrWhiteSpace(Name);

        string IIdentified.Identifier 
            => Name;

        public bool Equals(T src)
            => src != null && string.Compare(src.Name, this.Name, true) == 0;
        
        public int CompareTo(T other)
            => Name.CompareTo(other?.Name ?? string.Empty);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()        
            => Name.GetHashCode();

        public override bool Equals(object src)
            => src is T p && Equals(p);

        public int CompareTo(IIdentified src)
            => src is T p ? CompareTo(p) : -1;
    }
}