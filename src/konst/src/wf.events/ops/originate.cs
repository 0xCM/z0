//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='EventOrigin'/>
        /// </summary>
        /// <param name="name">The origin name</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which the calling member is defined</param>
        /// <param name="line">The invocation line number</param>
        [MethodImpl(Inline), Op]
        public static EventOrigin originate(string name, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new EventOrigin(name, new CallingMember(caller, file, line ?? 0));

        /// <summary>
        /// Defines a <see cref='EventOrigin'/>
        /// </summary>
        /// <param name="type">The origin type</param>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which the calling member is defined</param>
        /// <param name="line">The invocation line number</param>
        /// <typeparam name="T">The orgin type</typeparam>
        [MethodImpl(Inline), Op]
        public static EventOrigin originate(Type type,[Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => originate(type.Name, caller, file, line);

        /// <summary>
        /// Defines a <see cref='EventOrigin'/>
        /// </summary>
        /// <param name="caller">The calling member</param>
        /// <param name="file">The file in which the calling member is defined</param>
        /// <param name="line">The invocation line number</param>
        /// <typeparam name="T">The orgin type</typeparam>
        [Op]
        public static EventOrigin originate<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => originate(typeof(T), caller, file, line);



    }
}