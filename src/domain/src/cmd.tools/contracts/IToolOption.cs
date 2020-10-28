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

    public interface IToolOption
    {
        ushort Id {get;}

        StringRef Name {get;}

        utf8 Value {get;}
    }

    public interface IToolOption<F> : IToolOption
        where F : unmanaged
    {
        new F Id {get;}

        ushort IToolOption.Id
            => uint16(Id);
    }

    public interface IToolOption<F,K> : IToolOption<F>
        where F : unmanaged
        where K : unmanaged
    {
        new K Value {get;}

        utf8 IToolOption.Value
            => default;
    }
}