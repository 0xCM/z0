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
    /// Identifies a concreate <see cref='ICmdSpec'/> realization
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class CmdAttribute : Attribute
    {
        public CmdAttribute()
        {
        }
    }
}