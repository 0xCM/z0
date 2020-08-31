//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartLogExtensions
    {
        /// <summary>
        /// Extension for application status logs
        /// </summary>
        FileExtension StatusLog => FileExtensions.StatusLog;

        /// <summary>
        /// Extension for error output capture logs
        /// </summary>
        FileExtension ErrorLog => FileExtensions.ErrorLog;
    }
}