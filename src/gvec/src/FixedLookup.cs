//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static z;
    using static Konst;

    public class CellGraph
    {

    }

    public struct CellNode<T>
        where T : unmanaged, IDataCell<T>
    {
        readonly CellGraph G;

        T Data;

        [MethodImpl(Inline)]
        public CellNode(CellGraph g, T payload)
        {
            G =g;
            Data = payload;
        }
    }

    public interface IHashCodeProvider<H,S,T>
        where H : struct, IHashCodeProvider<H,S,T>
        where T : unmanaged
    {
        T Hash(S src);
    }

    public readonly struct HasherProvider32<S> : IHashCodeProvider<HasherProvider32<S>, S, uint>
    {
        public uint Hash(S src)
        {
            return default;
        }

    }

    public readonly struct HashProvider32x32 : IHashCodeProvider<HashProvider32x32, uint, uint>
    {
        public uint Hash(uint src)
            => src;
    }


    public readonly struct ConstLookup8x32
    {
        internal readonly uint[] Data;


        public ConstLookup8x32(uint[] src)
        {
            Data = src;
        }

        public ref readonly uint this[byte index]
        {
            get => ref Data[index];
        }
    }

    [ApiHost]
    public readonly struct ConstLookup
    {
        [Op]
        public static ConstLookup8x32 create8x32(uint[] src)
        {
            var limit = byte.MaxValue;
            var buffer = sys.alloc<uint>(limit);
            var target = span(buffer);
            var hasher = new HashProvider32x32();
            var input = @readonly(src);
            var count = (byte)math.min(limit, src.Length);
            var index = 0u;
            if(count > 0)
            {
                while(index < count)
                {
                    ref readonly var item = ref skip(input, index++);
                    var key = (byte)(hasher.Hash(item) % limit);
                    seek(target,key) = item;
                }
            }

            return new ConstLookup8x32(buffer);
        }
    }



}