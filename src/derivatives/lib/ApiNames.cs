//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using static ApiNameParts;

namespace Z0
{
    readonly struct ApiNames
    {

    }
}

namespace System.IO
{
    readonly struct ApiNames
    {
        public const string TempFiles =  system + dot + io + dot + "tempfiles";
    }
}

namespace System.Reflection.Emit
{
    readonly struct ApiNames
    {
        public const string DispatcherProxy = system + dot + reflection + dot + emit + dot + "dispatcherproxy";
    }
}

namespace System.Reflection.Metadata
{
    readonly struct ApiNames
    {
        public const string XSrm = system + dot + reflection + dot + metadata + dot + extensions;
    }
}

namespace Z0.LLVM
{
    readonly struct ApiNames
    {
        const string llvm = nameof(llvm);

        const string char6 = nameof(char6);

        public const string Char6 = llvm + dot + char6;
    }
}