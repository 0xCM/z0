//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using A = AsciLetterLoCode;

    public class StringTable<S>
        where S : unmanaged
    {
        Grid<bit> Data;

        String<S> String;

        Alphabet<S> Alphabet;

        // Number of rows is the number of characters in the string
        // Number of columns is the number of letterns in the alphabet
        public StringTable(String<S> s, Alphabet<S> a)
        {
            String = s;
            Alphabet = a;
            Data = new Grid<bit>((s.Count, a.MemberCount), alloc<bit>(s.Count*a.MemberCount));
        }
    }

    public readonly partial struct Strings
    {
        public static Alphabet<S> alphabet<S>(Func<char,S> f)
            where S : unmanaged, Enum
        {
            var index = Symbols.index<S>().View;
            var letters = hashset<Symbol<S>>();
            foreach(var s in index)
            {
                foreach(var a in s.Expr.Text)
                    letters.Add(f(a));
            }
            return new Alphabet<S>(letters);
        }
        public static String<S> @string<S>(params Symbol<S>[] src)
            where S : unmanaged
                => new String<S>(src);

        public static String<S> @string<S>(params S[] src)
            where S : unmanaged
                => new String<S>(src.Select(x => new Symbol<S>(x)));
    }

    [ApiHost("models.automata")]
    public readonly partial struct Automata
    {
        public static Automaton<A,byte> automaton(N1 n)
        {
            var letters = hashset<Symbol<A>>();
            var s0 = Symbol<A>.Empty;
            letters.Add(s0);
            var blk = Symbols.index<BinaryBitLogicKind>().View;
            //var accepted = hashset<String<Symbol<AsciLetterLoCode>>>();
            foreach(var s in blk)
            {
                foreach(var a in s.Expr.Text)
                    letters.Add((A)a);
            }


            var alphabet = new Alphabet<AsciLetterLoCode>(letters);
            return default;
        }
    }
}