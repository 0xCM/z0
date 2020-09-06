//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Classifier for application messages
    /// </summary>
    public enum MessageKind
    {
        /// <summary>
        /// Boring
        /// </summary>
        Unspecified = FlairKind.Unspecified,

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
        /// Dark blue foreground
        /// </summary>
        HiliteBD = FlairKind.Created,

        /// <summary>
        /// Light blue foreground
        /// </summary>
        HiliteBL = FlairKind.Blue,

        /// <summary>
        /// Dark cyan foreground
        /// </summary>
        HiliteCD = FlairKind.DataRow,

        /// <summary>
        /// Cyan foreground
        /// </summary>
        HiliteCL = FlairKind.Ran,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = FlairKind.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = FlairKind.Running,
    }
}