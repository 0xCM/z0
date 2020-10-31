//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    class App : TestApp<App>
    {
        public static void Main(params string[] args)
            => Run(args);
    }

    readonly struct ApiNames
    {
        const string bitlogix = nameof(bitlogix);

        const string checks = nameof(checks);

        public const string BinaryBitLogixCheck = bitlogix + dot + checks + binary;
    }
}