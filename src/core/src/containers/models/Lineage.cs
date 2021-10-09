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
        public static Lineage root(string name)
            => new Lineage(name);

        public static Lineage path(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            if(count == 0)
                return Lineage.Empty;

            var dst = alloc<Lineage>(count);
            ref readonly var input = ref first(src);
            var _root = root(input);
            first(dst) = _root;
            var current = _root;
            for(var i=1; i<count; i++)
            {
                current = current.Child(skip(input,i));
                seek(dst,i) = current;
            }
            return current;
        }

        Lineage(string name, Lineage ancestor)
        {
            Name = name;
            Ancestor = ancestor;
            IsEmpty = false;
        }

        Lineage(string name)
        {
            Name = name;
            Ancestor = Empty;
            IsEmpty = false;
        }

        Lineage()
        {
            Name = EmptyString;
            IsEmpty = true;
        }

        public Lineage Ancestor {get;}

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
            get => Ancestor != null && Ancestor.IsNonEmpty;
        }

        public Lineage Child(string name)
            => new Lineage(name, this);

        void Render(ITextBuffer dst)
        {
            if(IsNonEmpty && nonempty(Name))
            {
                dst.Append(Name);
                if(HasAncestor)
                {
                    dst.Append(" -> ");
                    Ancestor.Render(dst);
                }
            }
        }

        public Option<Lineage> Antecedant(string name)
        {
            if(HasAncestor)
                return Ancestor.Antecedant(name);

            return Option.none<Lineage>();
        }

        public string Format()
        {
            var dst = TextTools.buffer();
            Render(dst);
            return dst.Emit();
        }

        public override string ToString()
            => Format();

        public static Lineage Empty => new Lineage();
    }
}