//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public interface IPrimalKind : IKind<PrimalKind>
    {

    }

    public interface IPrimalKind<T> : IPrimalKind
        where T : unmanaged
    {

    }
}