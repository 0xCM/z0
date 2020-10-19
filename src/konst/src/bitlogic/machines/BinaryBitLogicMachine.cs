//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;

    public readonly struct BinaryBitLogicMachine<W,T> : IBinaryBitLogicMachine<BinaryBitLogicMachine<W,T>,W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        public T Evaluate<K>(T a, T b, K k = default)
            where K : unmanaged, IBitLogicKind
        {
            return default;
        }

        public T Evaluate(T a, T b, BinaryBitLogicKind kind)
        {
            throw new NotImplementedException();
        }
    }
}