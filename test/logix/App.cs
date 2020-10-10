//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameAtoms;

    class App : TestApp<App>
    {
        public static void Main(params string[] args)
            => Run(args);
    }

    readonly struct ApiNames
    {
        const string bitlogix = nameof(bitlogix);

        const string checks = nameof(checks);

        const string binary = nameof(binary);

        const string unary = nameof(unary);

        const string ternary = nameof(ternary);

        public const string BinaryBitLogixCheck = bitlogix + dot + checks + binary;
    }
}