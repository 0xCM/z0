//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfEventId<T> : IComparable<T>, IEquatable<T>, INamed<T>, ICorrelated<T>, IChronic<T>, ITextual
        where T : struct, IWfEventId<T>
    {

    }
}