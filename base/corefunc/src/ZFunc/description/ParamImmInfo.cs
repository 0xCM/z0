//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public readonly struct ParamImmInfo
    {
        public ParamImmInfo(string ParamName, int ParamIndex, PrimalKind ImmType)
        {
            this.ParamName = ParamName;
            this.ParamIndex = ParamIndex;
            this.ImmediateType = ImmType;
        }

        public readonly string ParamName;

        public readonly int ParamIndex;

        public readonly PrimalKind ImmediateType;

        public string Format()
            => $"{ParamName} : {ImmediateType}";
    }

}