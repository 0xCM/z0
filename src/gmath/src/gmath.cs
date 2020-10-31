//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    [ApiHost(ApiNames.gmath)]
    public partial class gmath : IApiHost<gmath>
    {

    }

    [ApiHost("as.numeric")]
    public partial class AsNumeric
    {

    }

    [ApiHost(ApiNames.Partition)]
    public partial class Partition
    {

    }


    public static partial class XTend
    {

    }

    readonly struct ApiNames
    {
        const string generic = nameof(generic);

        const string math = nameof(math);

        public const string gmath =  math + dot + generic;

        public const string algorithms = nameof(algorithms);

        public const string AlG = math + dot + generic + dot + algorithms;

        public const string XAlG = math + dot + generic + dot + algorithms + dot + extensions;

        public const string Partition = math + dot + "partition";

        public const string Seq = math + dot + seq;
    }
}