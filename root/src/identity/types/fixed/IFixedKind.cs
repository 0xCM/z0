//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    /// <summary>
    /// Characterizes a kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind : IHigherKind
    {
        int BitWidth {get;}
    }

    /// <summary>
    /// Characterizes a reified kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind<F> : IFixedKind
        where F : unmanaged, IFixed
    {
        int IFixedKind.BitWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<F>();
        }
    }
}