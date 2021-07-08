//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Collects random examples
    /// </summary>
    [ApiHost("vex.examples")]
    public sealed partial class VexExamples : t_inx<VexExamples>
    {
        VClaims VClaims => default;

        public override bool Enabled => true;
    }

    public static partial class MoreApiX
    {
        public static IApiHost Single(this IApiHost[] src, Type t)
            => src.Where(x => x.GetType() == t).Single();
    }

    [ApiHost("vex.examples.runner")]
    public sealed class VexExampleRunner: t_inx<VexExampleRunner>
    {
        uint Successes;

        uint Failures;

        public VexExampleRunner()
        {
            Successes = 0;
            Failures  = 0;
        }

        [Op]
        public void Run()
        {
            var examples = new VexExamples();
            Run(examples.e_duplicate);
            Run(examples.covers);
            Run(examples.vgather_128);
            Run(examples.vgather_256);
            Run(examples.vgather_blocks);
            Run(examples.vmerge_128);
            Run(examples.vmerge_256);
            Run(examples.vmerge_hi);
            Run(examples.vmerge_hilo);
            Run(examples.vmerge_lo);
            Run(examples.e_vperm4x16);
            Run(examples.e_vperm4x32_128x32u_A);
            Run(examples.e_vperm4x32_128x32u_B);

            Run(examples.vshuf16x16);
            Run(examples.vshuf16x8_128x8u);
            //Run(examples.vshuf16x8);
        }

        [MethodImpl(Inline),Op]
        public void Run(Action f)
        {
            try
            {
                f();
                Successes++;
            }
            catch(Exception e)
            {
                Trace(e.Message);
            }
        }
    }

    public readonly struct ExampleGroups
    {
        public const string Perms = nameof(Perms);

        public const string Shuffles = nameof(Shuffles);

        public const string Merge = nameof(Merge);

        public const string Gather = nameof(Gather);

        public const string Cover = nameof(Cover);

        public const string Duplicate = nameof(Duplicate);
    }
}