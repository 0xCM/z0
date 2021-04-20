//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static memory;
    using static Part;
    using static AsmTokens;

    [Free]
    public interface IRegOp : IAsmOp, ITextual
    {
        BitWidth ISized.Width
            => (uint)Width;

        RegIndex Index {get;}

        RegClass Class {get;}

        new RegWidth Width {get;}

    }

    [Free]
    public interface IRegOp<T> : IRegOp
        where T : unmanaged
    {
        AsmOpKind IAsmOp.OpKind
            => AsmOpKind.R | (AsmOpKind)width<T>(w16);

        BitWidth ISized.Width
            => width<T>();

        string ITextual.Format()
            => ToString();
    }
}