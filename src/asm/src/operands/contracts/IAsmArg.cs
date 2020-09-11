//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;

    public interface IAsmArg : ISized
    {
        /// <summary>
        /// The operand sort
        /// </summary>
        AsmOperandKind OpKind {get;}
    }

    public interface IAsmArg<T> : IAsmArg
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Content {get;}

        uint ISized.Width
            => bitsize<T>();
    }

    public interface IAsmArg<W,T> : IAsmArg<T>
        where W : unmanaged, IDataWidth
    {

    }

    public interface IAsmArg<F,W,T> : IAsmArg<W,T>
        where F : unmanaged, IAsmArg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        new W Width => default(W);
    }
}