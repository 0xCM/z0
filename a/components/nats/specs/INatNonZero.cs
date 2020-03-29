//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Requires k:K => k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public interface INatNonZero<K>
        where K : unmanaged, ITypeNat
    {

    }
}