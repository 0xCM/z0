//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ISymbolicTest<S>
        where S : unmanaged
    {
        bool Check(S s);
    }

    public interface ISymbolicTest<H,S> : ISymbolicTest<S>
        where H : unmanaged, ISymbolicTest<H,S>
        where S : unmanaged
    {

    }
}