//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Captures a dependency relationship between two assemblies
    /// </summary>
    [Record(TableId)]
    public struct AssemblyRefInfo : IRecord<AssemblyRefInfo>
    {
        public const string TableId = "cli.assemblyref";

        public Name Source;

        public Name Target;

        public BinaryCode Token;
    }
}