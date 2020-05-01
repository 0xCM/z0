//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    

    /// <summary>
    /// Characterizes an application settings provider that supports settings persistence
    /// </summary>
    public interface IAppSettingsProvider : ITextual
    {
        /// <summary>
        /// The provided settings
        /// </summary>
        IEnumerable<IAppSetting> Settings {get;}

        /// <summary>
        /// Saves the settings to a file
        /// </summary>
        /// <param name="dst">The target path</param>        
        void Save(FilePath dst);        
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic app setting set reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAppSettingsProvider<F> : IAppSettingsProvider, ITextual<F>
        where F : IAppSettingsProvider<F>, new()
    {
        
    }
}