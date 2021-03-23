//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Characterizes an application settings provider that supports settings persistence
    /// </summary>
    public interface ISettingSource : ITextual
    {
        /// <summary>
        /// The provided settings
        /// </summary>
        IEnumerable<ISetting> Settings {get;}

        /// <summary>
        /// Saves the settings to a file
        /// </summary>
        /// <param name="dst">The target path</param>
        void Save(Stream dst);
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic app setting set reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ISettingSource<F> : ISettingSource, ITextual<F>
        where F : ISettingSource<F>, new()
    {

    }
}