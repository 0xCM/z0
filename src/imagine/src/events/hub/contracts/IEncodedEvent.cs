//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IEncodedEvent : IAppEvent
    {
        StringRef Id {get;}

        BinaryCode Data {get;}    

        string ITextual.Format()
        {
            var dst = text.build();
            dst.Append(Id);
            dst.Append(Chars.Space);
            dst.Append(Chars.Pipe);
            dst.AppendLine(Data.Format());
            return dst.ToString();
        }    
    }

    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IEncodedEvent<F> : IEncodedEvent, IAppEvent<F>
        where F : struct, IEncodedEvent<F>
    {


    }
}