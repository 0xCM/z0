//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe partial struct Utf8
    {
        [MethodImpl(Inline), Op]
        public static uint hash(utf8 src)
            => alg.hash.marvin(src.View);

        [MethodImpl(Inline), Op]
        public static uint hash(utf8p src)
            => alg.hash.marvin(src.View);
    }
}