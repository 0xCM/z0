//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfFuncArgs
    {
        readonly TableSpan<WfFuncArg> Data;

        [MethodImpl(Inline)]
        public WfFuncArgs(params WfFuncArg[] src)
            => Data = src;

        [MethodImpl(Inline)]
        WfFuncArgs(int i)
        {
            Data = TableSpan<WfFuncArg>.Empty;
        }

        public ReadOnlySpan<WfFuncArg> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfFuncArgs(WfFuncArg[] src)
            => new WfFuncArgs(src);

        [MethodImpl(Inline)]
        public static implicit operator WfFuncArg[](WfFuncArgs src)
            => src.Data.Storage;

        public static WfFuncArgs Empty
            => new WfFuncArgs(0);
    }
}