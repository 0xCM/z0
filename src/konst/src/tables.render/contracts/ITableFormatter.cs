//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableFormatter<F> : ITextual
        where F : unmanaged, Enum
    {
        void EmitEol();

        string FormatHeader();

        void EmitHeader();
    }

    public interface ITableFormatter<F,T>
        where F : unmanaged, Enum
        where T : struct
    {
        string FormatHeader();

        string FormatRow(in T src);
    }
}