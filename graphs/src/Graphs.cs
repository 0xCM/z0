//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Graphs)]

namespace Z0.Parts
{
    public sealed class Graphs : Part<Graphs>
    {        
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Graphs
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;        

        public const string Connector = " -> ";
    }
}