//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public interface ITableFormatter<F> : ITextual
        where F : unmanaged, Enum
    {
        void EmitEol();        

        void EmitHeader();
    }

}