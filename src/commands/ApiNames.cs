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

    using static ApiNameParts;
    using System.CodeDom;

    readonly struct ApiNames
    {

        const string samples = nameof(samples);


        const string commands = nameof(commands);

        public const string XCmdSamples = cmd + dot + samples + dot + extensions;

        public const string XCmdSpecs = cmd + dot + specs + dot + extensions;

        public const string CmdSpecs = cmd + dot + specs;

    }
}