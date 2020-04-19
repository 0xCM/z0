//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Kinds
    {
        public readonly struct And<W,T> : IBitLogicKind<And,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Or<W,T> : IBitLogicKind<Or,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Xor<W,T> : IBitLogicKind<Xor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Nand<W,T> : IBitLogicKind<Nand,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }

        public readonly struct Nor<W,T> : IBitLogicKind<Nor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }
        
        public readonly struct Xnor<W,T> : IBitLogicKind<Xnor,W,T> where W : unmanaged, ITypeWidth where T : unmanaged { }
    }
}