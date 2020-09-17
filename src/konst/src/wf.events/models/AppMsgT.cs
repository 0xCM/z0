//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppMsg<T> : IAppMsg<T>
    {
        readonly AppMsgData<T> Data;

        [MethodImpl(Inline)]
        public static implicit operator AppMsg<T>(in AppMsgData<T> src)
            => new AppMsg<T>(src);

        [MethodImpl(Inline)]
        public AppMsg(AppMsgData<T> src)
            => Data = src;

        public MessageKind Kind
        {
            [MethodImpl(Inline)]
            get => Data.Kind;
        }

        public FlairKind Flair
        {
            [MethodImpl(Inline)]
            get => Data.Flair;
        }

        public T Content
        {
            [MethodImpl(Inline)]
            get => Data.Content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();
    }
}