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
        public DivisorIndex(Interval<T> Range, IReadOnlyList<DivisorList<T>> Lists)
        {
            this.Range = Range;
            this.Lookup = Lists.ToDictionary(x => x.Dividend, x => x);
        }

        public Interval<T> Range {get;}        

        IReadOnlyDictionary<T,DivisorList<T>> Lookup {get;}

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