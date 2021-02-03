//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public class StringTable
    {
        public static StringTable create(Index<string> src)
            => new StringTable(src);

        readonly Index<string> Data;

        readonly Dictionary<string,Paired<uint,string>> Keys;

        internal StringTable(Index<string> src)
        {
            Data = src;
            Keys = new Dictionary<string, Paired<uint,string>>(src.Length);
            var entries = src.View;
            var count = entries.Length;
            for(var i=0u; i<count; i++)
            {
                var item = memory.skip(entries, i);
                Keys.Add(item, (i,item));
            }
        }

        [MethodImpl(Inline)]
        public bool Contains(string item)
            => Keys.ContainsKey(item);

        [MethodImpl(Inline)]
        public bool Index(string item, out uint index)
        {
            if(Keys.TryGetValue(item, out var pair))
            {
                index = pair.Left;
                return true;
            }
            index = uint.MaxValue;
            return false;
        }

        [MethodImpl(Inline)]
        public string Entry(uint index)
            => Data[index];

        public ReadOnlySpan<string> Entries
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}