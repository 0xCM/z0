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
        readonly XedContextData[] Data;

        public ref readonly XedContextData ContextData
        {
            [MethodImpl(Inline), Op]
            get => ref Data[0];
        }

        [MethodImpl(Inline)]
        XedContext(in XedContextData data)
            : this()
        {
            Data = new XedContextData[1]{data};
        }
    }
}