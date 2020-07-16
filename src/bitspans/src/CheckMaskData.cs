//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   using System;

   using static z;

    partial class XTend
    {
        public static T[] CheckMaskData<T>(Type declarer)
            where T : unmanaged
        {
            const string  Error = "The binary literal value and the mask attribution data to not agree";

            static string Msg()
                => Error;

            var literals = BinaryLiterals.attributed<T>(Konst.base2, declarer);
            var count = literals.Length;
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)        
            {
                var mask = literals[i];
                var bits = BitSpans.parse(mask.Text);
                var bitval = bits.Convert<T>();
                insist(gmath.eq(bitval, mask.Data), Msg);
            }

            return buffer;            
        }
    }
}