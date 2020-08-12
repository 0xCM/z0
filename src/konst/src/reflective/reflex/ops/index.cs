//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.ClrData;

    using static Konst;
    using static z;
    
    partial struct Reflex
    {
          [MethodImpl(Inline), Op]
          public static ClrTypes index(Assembly src)
              => ClrTypes.create(types(src));
    }
}