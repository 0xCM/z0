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
    using System.IO;

    using static zfunc;

    public static class OpX
    {
        

        [MethodImpl(Inline)]
        public static bool IsGeneric(this Genericity src)
            => src == Genericity.Generic;




    }

}

