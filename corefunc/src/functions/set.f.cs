//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]   
    public static ISet<T> set<T>(params T[] src)
        => src.ToHashSet();

}