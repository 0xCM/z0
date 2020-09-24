//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static TextResource<E> define<E>(E id, MemoryAddress location, string value)
            where E : unmanaged, Enum
                => new TextResource<E>(id,location,value);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci2> define(in asci32 name, asci2 content, asci64? description = null)
            => resource(name, content, description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci4> define(in asci32 name, asci4 content, asci64? description = null)
            => resource(name, content, description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci8> define(in asci32 name, asci8 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci16> define(in asci32 name, asci16 content, asci64? description = null)
            => resource(name, content, description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci32> define(in asci32 name, asci32 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci64> define(in asci32 name, asci64 content, asci64? description = null)
            => resource(name,content,description);

        /// <summary>
        /// Creates an asci resource
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        static AsciResource<A> resource<A>(asci32 name, A content, asci64? description = null)
            where A : IBytes
                => new AsciResource<A>(name, content, description);
    }
}