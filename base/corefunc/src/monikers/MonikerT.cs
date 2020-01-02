//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct Moniker<T>
    {
        /// <summary>
        /// The moniker classifier
        /// </summary>
        public readonly string Name;

        public readonly string Text;
        
        [MethodImpl(Inline)]
        public static implicit operator Moniker(Moniker<T> src)
            => new Moniker(src.Text);

        [MethodImpl(Inline)]
        internal Moniker(string name)
        {
            this.Name = name;
            this.Text = moniker<T>(name);
        }

        public override string ToString()
            => Text;
    }

}