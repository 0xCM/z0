//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppResource : IAppResource<string>
    {
        public readonly string Name;

        public readonly string Content;

        [MethodImpl(Inline)]
        public static implicit operator AppResource<string>(AppResource src)
            => new AppResource<string>(src.Name,src.Content);
        
        [MethodImpl(Inline)]
        public AppResource(string name, string data)
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

        string IAppResource.Name
            => Name;

        string IAppResource<string>.Content 
            => Content;

        public static AppResource Empty 
            => new AppResource(EmptyString, EmptyString);

    }
}