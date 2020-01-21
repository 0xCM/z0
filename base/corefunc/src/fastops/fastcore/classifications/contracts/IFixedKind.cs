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

    /// <summary>
    /// Characterizes types/kinds with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedKind : IKind<FixedWidth>
    {

        FixedWidth FixedWidth {get;}

        FixedWidth IKind<FixedWidth>.Classifier 
        {
             [MethodImpl(Inline)]
             get  => FixedWidth;
        }

    }
}
