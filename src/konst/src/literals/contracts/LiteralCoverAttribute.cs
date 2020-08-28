//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Identifies a specialized literal cover
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class LiteralCoverAttribute : Attribute
    {

    }

}