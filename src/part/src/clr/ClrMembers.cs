//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    [ApiHost]
    public readonly struct ClrMembers
    {
        [MethodImpl(Inline), Op]
        public static MemberAddress address(ClrMember member, MemoryAddress address)
            => new MemberAddress(member,address);

        /// <summary>
        /// Computes the <see cref='MemberAddress'/> of a specified <see cref='MethodInfo'/>
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress address(MethodInfo src)
            => new MemberAddress(src, src.MethodHandle.Value.ToPointer());

        /// <summary>
        /// Computes the <see cref='MemberAddress'/> of a specified <see cref='FieldInfo'/>
        /// </summary>
        /// <param name="src">The source member</param>
        [MethodImpl(Inline), Op]
        public static unsafe MemberAddress address(FieldInfo src)
            => new MemberAddress(src, src.FieldHandle.Value.ToPointer());
    }
}