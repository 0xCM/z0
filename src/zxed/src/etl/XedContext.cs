//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Xed;

    [ApiHost]
    public readonly partial struct XedContext
    {
        readonly XedState[] Data;

        public ref readonly XedState ContextData
        {
            [MethodImpl(Inline), Op]
            get => ref Data[0];
        }

        [MethodImpl(Inline)]
        XedContext(in XedState data)
            : this()
        {
            Data = new XedState[1]{data};
        }
    }
}