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
        public readonly struct And<W,T> : IBitLogicKind<And,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Nand<W,T> : IBitLogicKind<Nand,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Or<W,T> : IBitLogicKind<Or,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Nor<W,T> : IBitLogicKind<Nor,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Xor<W,T> : IBitLogicKind<Xor,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Xnor<W,T> : IBitLogicKind<Xnor,W,T> where W : unmanaged, ITypeWidth {}
        
        public readonly struct Impl<W,T> : IBitLogicKind<Impl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct NonImpl<W,T> : IBitLogicKind<NonImpl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct CImpl<W,T> : IBitLogicKind<CImpl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct CNonImpl<W,T> : IBitLogicKind<CNonImpl,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Not<W,T> : IBitLogicKind<Not,W,T> where W : unmanaged, ITypeWidth {}

        public readonly struct Select<W,T> : IBitLogicKind<Select,W,T> where W : unmanaged, ITypeWidth {}



    }
}