//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct term
    {
        /// <summary>
        /// Reads a line of text from the terminal
        /// </summary>
        public static string read()
            => T.ReadLine();

        /// <summary>
        /// Reads a character from the terminal
        /// </summary>
        public static char readKey(string content = null)
            => T.ReadKey(content != null ? AppMsg.called(content, LogLevel.HiliteCL) : null);

        /// <summary>
        /// Reads a line of text from the terminal after printing a supplied message
        /// </summary>
        public static string read(string content = null)
            => T.ReadLine(content != null ? AppMsg.called(content, LogLevel.HiliteCL) : null);
    }
}