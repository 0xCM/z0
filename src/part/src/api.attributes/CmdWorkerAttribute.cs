//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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