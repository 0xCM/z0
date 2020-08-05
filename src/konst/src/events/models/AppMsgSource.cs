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

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Specifies application message origination details
    /// </summary>
    public readonly struct AppMsgSource : ITextual
    {                        
        [MethodImpl(Inline)]
        public static AppMsgSource create(PartId part, string caller, string file, int? line)        
            => new AppMsgSource(part, caller, file, line);

        [MethodImpl(Inline)]
        public static AppMsgSource create([Caller]string caller = null, [File]string file = null, [Line]int? line = null)        
            => new AppMsgSource(PartId.None, caller, file, line);

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
        public AppMsgSource(PartId part, string caller, string file, int? line)
        {
            Part = part;
            Caller = caller;
            File = FilePath.Define(file ?? EmptyString);
            Line = (uint)(line ?? 0);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (File is null) ? true : text.blank(Caller) || File.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => (File is null) ? false : (text.nonempty(Caller) || File.IsNonEmpty);
        }

        public string Format()
        {
            if(Part != 0)
                return $"{Part.Format()}/{File.FileName}/{Caller}?line = {Line} | {File}";
            else
                return $"{File.FileName}/{Caller}?line = {Line} | {File}";
        }
        
        public override string ToString()
            => Format();

        public static AppMsgSource Empty         
            => new AppMsgSource(0, EmptyString, EmptyString, 0);
    }
}