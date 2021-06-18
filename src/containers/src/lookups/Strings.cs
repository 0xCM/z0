//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public sealed class Strings
    {
        public static Strings create()
            => new Strings();

        HashSet<string> Data;

        public Strings()
        {
            Data = new();
        }

        public Strings(ReadOnlySpan<string> src)
        {
            Data = new();
            iter(src, s => Data.Add(s));
        }

        public Strings(IEnumerable<string> src)
        {
            Data = new();
            iter(src, s => Data.Add(s));
        }

        [MethodImpl(Inline)]
        public bool Add(string src)
        {
            return Data.Add(src);
        }

        [MethodImpl(Inline)]
        public uint Add(ReadOnlySpan<string> src)
        {
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
                counter += u8(Add(skip(src,i)));
            return counter;
        }

        public bool Contains(string src)
        {
            return Data.Contains(src);
        }

        public string[] Seal()
        {
            var data = Data.Array().Sort();
            Data.Clear();
            return data;
        }

        public bool CoversAny(string src)
        {
            foreach(var s in Data)
                if(src.Contains(s))
                    return true;
            return false;
        }
    }
}