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
        Unspecified = MessageFlair.Unspecified,

        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Babble = MessageFlair.DarkGray,

        /// <summary>
        /// Identifies informational content
        /// </summary>
        Info = MessageFlair.Green,

        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = MessageFlair.Yellow,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = MessageFlair.Red,

        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Benchmark = MessageFlair.Magenta,

        /// <summary>
        /// Dark blue foreground
        /// </summary>
        HiliteBD = MessageFlair.DarkBlue,

        /// <summary>
        /// Light blue foreground
        /// </summary>
        HiliteBL = MessageFlair.Blue,

        /// <summary>
        /// Dark cyan foreground
        /// </summary>
        HiliteCD = MessageFlair.DarkCyan,

        /// <summary>
        /// Cyan foreground
        /// </summary>
        HiliteCL = MessageFlair.Cyan,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = MessageFlair.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = MessageFlair.Magenta,
    }
}