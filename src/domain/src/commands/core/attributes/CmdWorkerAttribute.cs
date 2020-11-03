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

    /// <summary>
    /// Applied to a method to indicate that it can execute a <see cref='CmdSpec'/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CmdWorkerAttribute : OpAttribute
    {
        public CmdWorkerAttribute()
        {

        }
    }
}