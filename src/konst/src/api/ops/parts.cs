//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        public static IPart[] parts()
            => modules().Parts;

        [MethodImpl(Inline), Op]
        public static PartId[] parts(params string[] args)
            => args.Map(arg => Enums.Parse<PartId>(arg).ValueOrDefault()).WhereSome();

        [Op]
        public static IPart[] parts(Assembly[] src)
            => src.Where(isPart).Select(part).Where(x => x.IsSome()).Select(x => x.Value).OrderBy(x => x.Id);

        [Op]
        public static Assembly[] parts(FilePath[] src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => src.Map(f => ApiQuery.assembly(f, caller, file, line))
                      .Where(x => x.IsSome()).Select(x => x.Value).Where(test);

        [Op]
        public static Assembly[] parts(FS.FilePath[] src,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int?  line = null)
                => src.Map(f => ApiQuery.assembly(f, caller, file, line))
                      .Where(x => x.IsSome()).Select(x => x.Value).Where(test);
    }
}