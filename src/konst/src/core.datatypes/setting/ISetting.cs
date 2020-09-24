//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a nonparametric application setting
    /// </summary>
    public interface ISetting : ITextual
    {
        /// <summary>
        /// The setting name
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The setting value
        /// </summary>
        string Value {get;}
    }
}