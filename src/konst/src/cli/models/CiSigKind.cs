//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public enum CliSigKind : byte
    {
        Default = 0,

        MethodDef,

        MethodRef,

        StandAloneMethod,

        Field,

        Property,

        LocalVar
    }
}