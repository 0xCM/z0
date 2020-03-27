//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classifier for application messages
    /// </summary>
    public enum AppMsgKind
    {   
        /// <summary>
        /// Boring
        /// </summary>
        Unspecified = AppMsgColor.Unspecified,
        
        /// <summary>
        /// Identifies chatty content
        /// </summary>
        Babble = AppMsgColor.DarkGray,

        /// <summary>
        /// Identifies iformational content
        /// </summary>
        Info = AppMsgColor.Green,
        
        /// <summary>
        /// Identifies warning content
        /// </summary>
        Warning = AppMsgColor.Yellow,

        /// <summary>
        /// Identifies error content
        /// </summary>
        Error = AppMsgColor.Red,
        
        /// <summary>
        /// Identifies benchmark/timing result
        /// </summary>
        Benchmark = AppMsgColor.Magenta,

        /// <summary>
        /// Dark blue foreground 
        /// </summary>
        HiliteBD = AppMsgColor.DarkBlue,

        /// <summary>
        /// Light blue foreground 
        /// </summary>
        HiliteBL = AppMsgColor.Blue,

        /// <summary>
        /// Dark cyan foreground 
        /// </summary>
        HiliteCD = AppMsgColor.DarkCyan,

        /// <summary>
        /// Cyan foreground 
        /// </summary>
        HiliteCL = AppMsgColor.Cyan,

        /// <summary>
        /// Dark magenta foreground
        /// </summary>
        HiliteMD = AppMsgColor.DarkMagenta,

        /// <summary>
        /// Magenta foreground
        /// </summary>
        HiliteML = AppMsgColor.Magenta,
    }
}