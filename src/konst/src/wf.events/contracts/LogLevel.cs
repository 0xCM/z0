//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Classifier for application messages
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Boring
        /// </summary>
        None = FlairKind.Unspecified,

        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Babble = FlairKind.Initializing,

        /// <summary>
        /// Identifies informational content
        /// </summary>
        Info = FlairKind.Status,

        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = FlairKind.Warning,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = FlairKind.Error,

        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Benchmark = FlairKind.Running,

        /// <summary>
        /// Cyan foreground
        /// </summary>
        HiliteCL = FlairKind.Ran,


    }
}