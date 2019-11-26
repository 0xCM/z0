//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static As;
    using static zfunc;

    partial class MathX
    {
        [MethodImpl(Inline)]
        public static int ToBits(this float src)
            => BitConvert.ToInt32(src);

        [MethodImpl(Inline)]
        public static long ToBits(this double src)
            => BitConvert.ToInt64(src);

        public static Option<int> WriteTo<T>(this DivisorIndex<T> src, FolderPath dst)
            where T : unmanaged
        {
            var filename = FileName.Define($"divisors{src.Range}.csv");
            var outpath = dst + filename;
            var lists = src.Lists.OrderBy(x => x.Dividend);
            return outpath.Overwrite(lists.Select(d => d.ToString()).ToArray());
        }

        [MethodImpl(Inline)]
        public static T Quotient<T>(this Ratio<T> r)        
            where T : unmanaged       
                => gmath.div(r.A, r.B);
    }
}