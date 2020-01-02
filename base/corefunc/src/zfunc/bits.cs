//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

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