//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using static Root;

    partial struct Cli
    {
        [Op]
        public static CliReader reader(Assembly src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(MetadataReader src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(MemorySeg src)
            => new CliReader(src);

        [Op]
        public static CliReader reader(PEMemoryBlock src)
            => new CliReader(src);
    }
}