//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITableFormatter<F> : ITextual
        where F : unmanaged
    {
        void EmitEol();

        string FormatHeader();

        void EmitHeader();
    }
}