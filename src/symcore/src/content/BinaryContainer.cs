//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public abstract class BinaryContainer<T>
        where T : BinaryContainer<T>, new()
    {
        public static T Empty
            => new T();

        public BinaryCode Content {get; protected set;}

        public abstract ContentType ContentType {get;}

        protected BinaryContainer()
        {
            Content = BinaryCode.Empty;
        }

        [MethodImpl(Inline)]
        protected ref S Segment<S>(uint offset)
            where S : unmanaged
                => ref first(recover<S>(slice(Content.Edit,offset)));
    }
}