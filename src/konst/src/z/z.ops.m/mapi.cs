// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static Y[] mapi<X,Y>(IEnumerable<X> seq, Func<int,X,Y> f)
            => corefunc.mapi(seq,f);
    }
}