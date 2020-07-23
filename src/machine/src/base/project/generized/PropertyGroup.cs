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
    
    public readonly struct PropertyGroup
    {
        public const string TagName = nameof(PropertyGroup);

        public readonly ProjectProperty[] Properties;

        [MethodImpl(Inline)]
        public PropertyGroup(ProjectProperty[] src)
            => Properties = src;
    }
}