//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Flow
    {
        /// <summary>
        /// Creates a parametrically-predicated tool identifier
        /// </summary>
        /// <typeparam name="T">The tool type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfToolId<T> tool<T>()
            => default;

        /// <summary>
        /// Creates a predicated tool identifier
        /// </summary>
        [MethodImpl(Inline)]
        public static WfToolId tool(Type t)
            => new WfToolId(t);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(WfToolId<T> src)
            =>  src.Name;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ArtifactIdentifier identify<T>(WfToolId<T> src)
            =>  src.Id;
    }
}