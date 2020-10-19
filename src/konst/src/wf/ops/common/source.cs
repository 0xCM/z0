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

    partial struct Workflow
    {
        /// <summary>
        /// Defines a <see cref='AppMsgSource'/>
        /// </summary>
        /// <param name="caller">The member name</param>
        /// <param name="file">The caller file path</param>
        /// <param name="line">The caller line number</param>
        [MethodImpl(Inline), Op]
        public static AppMsgSource source([CallerMemberName]string caller = null, [CallerFilePath] string file = null, [CallerLineNumber]int? line = null)
            => new AppMsgSource(PartId.None, caller, file, line);

        /// <summary>
        /// Defines a <see cref='AppMsgSource'/>
        /// </summary>
        /// <param name="part">The calling part</param>
        /// <param name="caller">The member name</param>
        /// <param name="file">The caller file path</param>
        /// <param name="line">The caller line number</param>
        [MethodImpl(Inline), Op]
        public static AppMsgSource source(PartId part, [CallerMemberName]string caller = null, [CallerFilePath] string file = null, [CallerLineNumber]int? line = null)
            => new AppMsgSource(part, caller, file, line);
    }
}