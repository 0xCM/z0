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

    [AttributeUsage(AttributeTargets.Method)]
    public class CmdWorkerAttribute : Attribute
    {
        public CmdWorkerAttribute()
        {

        }
    }
}