//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static CallingMember caller([CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new CallingMember(caller, file, line ?? 0);

        [MethodImpl(Inline), Op]
        public static ref CallingMember caller(ref CallingMember dst, [CallerMemberName] string name = null, [CallerLineNumber] int? line = null, [CallerFilePath] string path = null)
        {
            dst.Name = name;
            dst.File = path;
            dst.FileLine = (uint)(line ?? 0);
            return ref dst;
        }
    }
}