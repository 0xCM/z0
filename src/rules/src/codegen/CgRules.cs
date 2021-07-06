//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CgRules
    {
        public static string FileHeader(bool ts = true) => ts ?
$@"//-----------------------------------------------------------------------------
// Generated   :  {Timestamp.now()}
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
"
:

@"//-----------------------------------------------------------------------------
// Generated
// Copyright   :  (c) Chris Moore, 2021
// License     :  MIT
//-----------------------------------------------------------------------------
";
    }

}