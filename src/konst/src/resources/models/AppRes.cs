//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppRes : IAppRes<string>
    {
        public readonly string Name;

        public readonly string Content;

        [MethodImpl(Inline)]
        public AppRes(string name, string data)
        {
            Name = name;
            Content = data;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Content);
        }
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        string IAppRes.Name
            => Name;

        string IAppRes<string>.Content
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator AppRes<string>(AppRes src)
            => new AppRes<string>(src.Name,src.Content);

        public static AppRes Empty
            => new AppRes(EmptyString, EmptyString);
    }
}