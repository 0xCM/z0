//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost]
    public readonly struct BuildScripts
    {
        public bool config<T>(string src, out T dst)
            where T : struct
        {
            dst = default;
            return true;
        }
    }
}