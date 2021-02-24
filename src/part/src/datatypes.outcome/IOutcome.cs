//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IOutcome : ITextual
    {
        bool Ok {get;}

        string Message {get;}
    }

    public interface IOutcome<T> : IOutcome
    {
        T Data {get;}
    }
}