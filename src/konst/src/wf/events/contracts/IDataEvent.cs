//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDataEvent : IAppEvent
    {
        StringRef Id {get;}

        BinaryCode Encoded {get;}    
        string ITextual.Format()
        {
            var dst = text.build();
            dst.Append(Id);
            dst.Append(Chars.Space);
            dst.Append(Chars.Pipe);
            dst.AppendLine(Encoded.Format());
            return dst.ToString();
        }    
    }

    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IDataEvent<H> : IDataEvent, IAppEvent<H>
        where H : struct, IDataEvent<H>
    {

    }    
}