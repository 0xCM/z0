//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class Kinds
    {
        public readonly struct Alloc<W,T> : ISystemOpKind<Alloc,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Store<W,T> : ISystemOpKind<Store,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Load<W,T> : ISystemOpKind<Load,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Init<W,T> : ISystemOpKind<Init,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Kind<W,T> : ISystemOpKind<Kind,W,T> where W : unmanaged, ITypeWidth {}    
    }
}