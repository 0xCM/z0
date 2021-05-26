//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.DiaSymReader;

    using static Part;
    using static PdbModel;

    public struct PdbMethodInfo : IRecord<PdbMethodInfo>
    {
        public CliToken Token;

        public SequencePoint[] SequencePoints;
    }
}