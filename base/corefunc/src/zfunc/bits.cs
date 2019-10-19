//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// A bit with state 1
    /// </summary>
    public static bit on
    {
        [MethodImpl(Inline)]
        get => bit.On;
    }

    /// <summary>
    /// A bit with state 0
    /// </summary>
    public static bit off
    {
        [MethodImpl(Inline)]
        get => bit.Off;
    }

}