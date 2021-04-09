//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Associates a contiguous sequence of dividends with their divisor lists
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DivisorIndex<T>
        where T : unmanaged
    {
        public Interval<T> Range {get;}

        IReadOnlyDictionary<T,DivisorList<T>> Lookup {get;}

        public DivisorIndex(Interval<T> range, Index<DivisorList<T>> lists)
        {
            Range = range;
            Lookup = lists.ToDictionary(x => x.Dividend, x => x);
        }

        public DivisorList<T> this[T dividend]
            => Lookup[dividend];

        public IEnumerable<DivisorList<T>> Lists
            => Lookup.Values;

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(var item in Lists)
                sb.AppendLine(item.ToString());
            return sb.ToString();
        }
    }
}