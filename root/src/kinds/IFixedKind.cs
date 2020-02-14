//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static RootShare;

    /// <summary>
    /// Characterizes a kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind : IKind<FixedWidth>
    {
        
    }

    /// <summary>
    /// Characterizes a reified kind with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind<F> : IFixedKind, IFixedWidth
        where F : unmanaged, IFixed
    {
        FixedWidth IFixedWidth.FixedWidth 
        {
            [MethodImpl(Inline)]
            get =>  (FixedWidth)bitsize<F>();
        }
        
        FixedWidth IKind<FixedWidth>.Classifier => (FixedWidth)bitsize<F>();

    }
}