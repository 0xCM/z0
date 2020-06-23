//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;

    public interface TCheckError : IMessagePrinter
    {
        IAppMsg Describe(Exception e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var msg = new StringBuilder();
            msg.AppendLine($"{title}: Failure ocuurred at {caller} {file} {line}");
            msg.AppendLine(e?.ToString() ?? string.Empty);
            return AppMsg.NoCaller($"{msg.ToString()}", AppMsgKind.Error);            
        }

        void Print(Exception e, string title, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Print(Describe(e, title, caller,file,line));       
    }
}