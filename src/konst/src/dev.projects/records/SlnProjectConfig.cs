//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct SlnProjectConfig : IRecord<SlnProjectConfig>
    {
        public const string TableId = "sln.project-config";

        public Name SimpleName;

        public Name Platform;

        public Name FullName;

        public bool Build;
    }
}