//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface ITextBuffer : ITextual
    {
        void Write(string src);

        string Emit(bool reset = true);

        void Clear();
    }

    public interface ITextBuffer<H> : ITextBuffer
        where H : struct, ITextBuffer<H>
    {

    }
}