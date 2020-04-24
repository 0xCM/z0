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
        public readonly struct TestZ<W,T> : IBitFunctionKind<TestZ,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct TestC<W,T> : IBitFunctionKind<TestC,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Ntz<W,T> : IBitFunctionKind<Ntz,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Nlz<W,T> : IBitFunctionKind<Nlz,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Pop<W,T> : IBitFunctionKind<Pop,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Mux<W,T> : IBitFunctionKind<Mux,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Scatter<W,T> : IBitFunctionKind<Scatter,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Gather<W,T> : IBitFunctionKind<Gather,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Mix<W,T> : IBitFunctionKind<Mix,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct Rank<W,T> : IBitFunctionKind<Rank,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct BitSeg<W,T> : IBitFunctionKind<BitSeg,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct TestBit<W,T> : IBitFunctionKind<TestBit,W,T> where W : unmanaged, ITypeWidth { }

        public readonly struct TestBits<W,T> : IBitFunctionKind<TestBits,W,T> where W : unmanaged, ITypeWidth { }
    }
}