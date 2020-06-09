//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMemoryRange<F> : IEquatable<F>, IComparable<F>, ITextual<F>
        where F : unmanaged, IMemoryRange<F>
    {

    }

}