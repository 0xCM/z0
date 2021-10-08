//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static core;

    partial struct Strings
    {
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
    }
}