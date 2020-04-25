//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a nonparametric application setting
    /// </summary>
    public interface IAppSetting : ICustomFormattable
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

    /// <summary>
    /// Characterizes a value-parametric application setting
    /// </summary>
    public interface IAppSetting<T> : IAppSetting
    {        
        /// <summary>
        /// The typed setting value
        /// </summary>
        new T Value {get;}

        string IAppSetting.Value => Value?.ToString() ?? string.Empty;
    }
}