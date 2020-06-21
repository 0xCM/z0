//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    partial class Root
    {
        //public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const string Kernel32 = "kernel32.dll";

        public const NumericKind Numeric64 = NumericKind.Width64;

        public const NumericKind Numeric16x32x64 = NumericKind.Width16 | NumericKind.Width32 | NumericKind.Width64;

        public const NumericKind Numeric32x64 = NumericKind.Width32 | NumericKind.Width64;

    }
}