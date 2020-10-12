//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiNameAtoms;

    readonly struct ApiNames
    {
        const string cil = nameof(cil);

        public const string CilApi = cil + dot + api;
    }
}