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

    partial struct BitLogic
    {
        public readonly struct UnaryMachine<T>
            where T : struct
        {


        }


        public readonly struct TernaryMachine<T>
            where T : struct
        {


        }

        public readonly struct BinaryMachine<W,T> : IBinaryBitLogicMachine<BinaryMachine<W,T>,W,T>
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
}