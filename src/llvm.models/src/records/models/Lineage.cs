//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class Lineage
    {
        [MethodImpl(Inline)]
        public static Lineage root(string name)
            => new Lineage(name);

        public static Lineage parse(string src)
        {
            var input = text.trim(src);
            if(empty(input))
                return Lineage.Empty;
            else if(input.Contains("->"))
            {
                var parts = @readonly(input.Split("->").Select(x => x.Trim()));
                var count = parts.Length;
                if(count == 0)
                    return Lineage.Empty;

                if(count == 1)
                    return new Lineage(first(parts));
                else
                    return new Lineage(first(parts), slice(parts,1).ToArray());
            }
            else
                return new Lineage(input);
        }

        public static Lineage path(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            if(count == 0)
                return Lineage.Empty;
            else if(count == 1)
                return new Lineage(first(src));
            else
                return new Lineage(first(src), slice(src,1).ToArray());
        }

        const string LeftToRight = " -> ";

        Lineage(string name, string[] ancestors)
        {
            Name = name;
            Ancestors = ancestors;
            IsEmpty = false;
        }

        Lineage(string name)
        {
            Name = name;
            Ancestors = Index<string>.Empty;
            IsEmpty = false;
        }

        Lineage()
        {
            Name = EmptyString;
            IsEmpty = true;
        }

        public Index<string> Ancestors {get;}

        public string Name {get;}

        public bool IsEmpty {get;}

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public bool HasAncestor
        {
            [MethodImpl(Inline)]
            get => Ancestors.IsNonEmpty;
        }

        public string Format()
        {
            var dst = TextTools.buffer();
            if(IsNonEmpty && nonempty(Name))
            {
                dst.Append(Name);
                var count = Ancestors.Count;
                for(var i=0; i<count; i++)
                {
                    dst.Append(LeftToRight);
                    dst.Append(Ancestors[i]);
                }
            }
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public static Lineage Empty => new Lineage();
    }
}