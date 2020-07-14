//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Specifies application message origination details
    /// </summary>
    public readonly struct AppMsgSource
    {                
        /// <summary>
        /// Specifies the emitting executable part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public readonly string Caller;
        
        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public readonly FilePath File;

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public readonly uint Line;

        [MethodImpl(Inline)]
        public AppMsgSource(PartId part, string caller, FilePath file, uint line)
        {
            Part = part;
            Caller = caller;
            File = file;
            Line = line;
        }

        [MethodImpl(Inline)]
        public AppMsgSource(PartId part, string caller, FilePath file, int? line)
        {
            Part = part;
            Caller = caller;
            File = file;
            Line = (uint)(line ?? 0);
        }
        public static AppMsgSource Empty 
            => new AppMsgSource(0, EmptyString, FilePath.Empty, 0);
    }
}