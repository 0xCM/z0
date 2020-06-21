//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   using System;
   using System.Runtime.CompilerServices;
   using System.Linq;
   using System.Collections.Generic;

   using static Konst;
   using static Memories;

    partial class XTend
    {
        public static T[] Validate<T>(this IEnumerable<BinaryLiteral<T>> src, Type declarer)
            where T : unmanaged
        {
            var literals = Literati.attributed<T>(Konst.base2, declarer).ToArray();
            var count = literals.Length;
            var dst = Root.alloc<T>(count);
            for(var i=0; i< count; i++)        
            {
                var mask = literals[i];
                var bits = BitSpans.parse(mask.Text);
                var bitval = bits.Convert<T>();
                insist(gmath.eq(bitval, mask.Data));
            }

            return dst;            
        }
    }

    public class BinaryLiteralValues
    {
        public static T[] extract<T>(Type declarer)
            where T : unmanaged
        {
            Span<BinaryLiteral<T>> literals = Literati.attributed<T>(Konst.base2, declarer).ToArray();
            
            var count = literals.Length;
            var dst = Root.alloc<T>(count);

            Span<T> target = dst;
            
            for(var i=0; i< count; i++)        
                seek(target,i) = skip(literals,i).Data;
            return dst;            
        }
    }
}