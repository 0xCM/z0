//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XApi
    {
        [Op]
        public static MethodDisplaySig DisplaySig(this MethodInfo src)
            => src.Artifact().DisplaySig;
    }
}