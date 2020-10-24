//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    /// <summary>
    /// Collects random examples
    /// </summary>
    [ApiHost("vex.examples")]
    public sealed partial class VexExamples : t_inx<VexExamples>
    {
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
        uint Counter;

        void CollectExamples()
        {
            var catalog = ApiCatalogs.part(typeof(VexExampleRunner).Assembly);
            if(catalog.ApiHosts.Host(typeof(VexExamples), out var host))
            {
                var methods = host.DeclaredMethods;
            }

        }

        [Op]
        public uint Run1()
        {
            var examples = new VexExamples();
            examples.vduplicate();
            examples.vcover();
            examples.vgather_128();
            examples.vgather_256();
            examples.vgather_blocks();
            examples.vmerge_128();
            examples.vmerge_256();
            examples.vmerge_hi();
            examples.vmerge_hilo();
            examples.vmerge_lo();
            examples.vperm4x16();
            examples.vperm4x32_128x32u_A();
            examples.vperm4x32_128x32u_B();
            examples.vshuf16x16();
            examples.vshuf16x8_128x8u();
            examples.vshuf16x8();
            return Counter;
        }

        [Op]
        public uint Run2()
        {
            var examples = new VexExamples();
            Run(examples.vduplicate);
            Run(examples.vcover);
            Run(examples.vgather_128);
            Run(examples.vgather_256);
            Run(examples.vgather_blocks);
            Run(examples.vmerge_128);
            Run(examples.vmerge_256);
            Run(examples.vmerge_hi);
            Run(examples.vmerge_hilo);
            Run(examples.vmerge_lo);
            Run(examples.vperm4x16);
            Run(examples.vperm4x32_128x32u_A);
            Run(examples.vperm4x32_128x32u_B);
            Run(examples.vshuf16x16);
            Run(examples.vshuf16x8_128x8u);
            Run(examples.vshuf16x8);
            return Counter;
        }

        [MethodImpl(Inline),Op]
        public void Run(Action f)
        {
            f();
            Counter++;
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