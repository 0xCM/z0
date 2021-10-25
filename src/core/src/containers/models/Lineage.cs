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
        public static Lineage node(string name)
            => new Lineage(name);

        public static Lineage path(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            if(count == 0)
                return Lineage.Empty;

            var dst = alloc<Lineage>(count);
            ref readonly var input = ref first(src);
            var start = node(input);
            first(dst) = start;
            var current = start;
            for(var i=1; i<count; i++)
            {
                current = current.CreateChild(skip(input,i));
                seek(dst,i) = current;
            }
            return current;
        }

        const string LeftToRight = " -> ";

        public static Outcome parse(string src, out Lineage dst)
        {
            if(src.Contains(LeftToRight))
                dst = path(src.SplitClean(LeftToRight));
            else
                dst = Empty;
            return true;
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

        public Lineage CreateChild(string name)
            => new Lineage(name, this);

        void Render(ITextBuffer dst)
        {
            if(IsNonEmpty && nonempty(Name))
            {
                dst.Append(Name);
                if(HasAncestor)
                {
                    dst.Append(LeftToRight);
                    Ancestor.Render(dst);
                }
            }
        }

        public Option<Lineage> Antecedant(string name)
        {
            if(HasAncestor)
                return Ancestor.Antecedant(name);
            else
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