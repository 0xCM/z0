//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a type for which nullity can be adjudicated
    /// </summary>
    public interface INullity
    {
        bool IsEmpty {get;}

        bool IsNonEmpty => !IsEmpty;
    }
}