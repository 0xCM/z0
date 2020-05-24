//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AppResource : IAppResource<string[]>
    {
        [MethodImpl(Inline)]
        public static implicit operator AppResource<string[]>(AppResource src)
            => new AppResource<string[]>(src.Name,src.Data);
        
        [MethodImpl(Inline)]
        public AppResource(string name, params string[] data)
        {
            this.Name = name;
            this.Data = data;
        }

        public string Name {get;}

        public string[] Data {get;}        

        public string Format()
        {
            var dst = text.build();
            Control.iter(Data, d => dst.AppendLine(d));
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}