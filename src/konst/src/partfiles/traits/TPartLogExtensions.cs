//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface TPartLogExtensions
    {
        /// <summary>
        /// Extension for application log files
        /// </summary>
        FileExtension Log => FileExtensions.Log;

        /// <summary>
        /// Extension for standard output capture logs
        /// </summary>
        FileExtension StdOut => FileExtensions.StdOut;

        /// <summary>
        /// Extension for error output capture logs
        /// </summary>
        FileExtension ErrOut => FileExtensions.ErrOut;
    }
}