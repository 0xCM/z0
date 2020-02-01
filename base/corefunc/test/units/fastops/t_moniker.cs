//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;
    using static Classifiers;

    public sealed class t_moniker : t_fastop<t_moniker>
    {
        static ref readonly Block128<T> add<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
            => ref c;



    }

}