//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;

    /// <summary>
    /// Specifies application message origination details
    /// </summary>
    public readonly struct AppMsgSource : ITextual
    {
        /// <summary>
        /// Specifies the emitting executable part
        /// </summary>
        public PartId Part {get;}

        /// <summary>
        /// The name of the member that originated the message
        /// </summary>
        public string Caller {get;}

        /// <summary>
        /// The path to the source file in which the message originated
        /// </summary>
        public string File {get;}

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public uint Line {get;}


        [MethodImpl(Inline)]
        public AppMsgSource(PartId part, string caller, string file, int? line)
        {
            Part = part;
            Caller = caller;
            File =file ?? EmptyString;
            Line = (uint)(line ?? 0);
        }

        public string Format()
        {
            if(Part != 0)
                return string.Format(KnownPartPattern, Part.Format(), Path.GetFileName(File), Caller, Line, File);
            else
                return string.Format(UnknownPartPattern, Path.GetFileName(File), Caller, Line, File);
        }

        public override string ToString()
            => Format();

        public static AppMsgSource Empty
            => new AppMsgSource(0, EmptyString, EmptyString, 0);

        const string KnownPartPattern = "{0}/{1}/{2}?line = {3} | {4}";

        const string UnknownPartPattern = "{0}/{1}?line = {2} | {3}";
    }
}