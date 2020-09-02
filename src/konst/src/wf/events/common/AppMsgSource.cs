//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Specifies application message origination details
    /// </summary>
    public readonly struct AppMsgSource : ITextual
    {
        public const string KnownPartPattern = "{0}/{1}/{2}?line = {3} | {4}";

        public const string UnknownPartPattern = "{0}/{1}?line = {2} | {3}";

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
        public readonly FS.FilePath File;

        /// <summary>
        /// The source file line number on which the message originated
        /// </summary>
        public readonly uint Line;

        [MethodImpl(Inline)]
        public AppMsgSource(PartId part, string caller, string file, int? line)
        {
            Part = part;
            Caller = caller;
            File = FS.path(file ?? EmptyString);
            Line = (uint)(line ?? 0);
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            if(Part != 0)
                return text.format(KnownPartPattern, Part.Format(), File.FileName, Caller, Line, File);
            else
                return text.format(UnknownPartPattern, File.FileName, Caller, Line, File);
        }

        public override string ToString()
            => Format();

        public static AppMsgSource Empty
            => new AppMsgSource(0, EmptyString, EmptyString, 0);
    }
}