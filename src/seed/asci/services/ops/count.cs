//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct asci
    {

        [MethodImpl(Inline)]
        public static int count<A>(A src, DigitGroup g)
            where A: unmanaged, IAsciSequence             
        {
            var count = 0;
            var data = codes(src);
            for(var i=0; i<data.Length; i++)
            {
                ref readonly var c = ref skip(data,i);

            }
            return count;
        }
    }
}