//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Characterizes a service that knows how to produce titles for things
    /// </summary>
    public interface ITitleFormatter
    {

    }

    /// <summary>
    /// Characterizes a parametric title formatter
    /// </summary>
    public interface ITitleFormatter<T> : ITitleFormatter
    {
        string FormatTitle(T src);
    }
}