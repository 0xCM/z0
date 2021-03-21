//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;


    public readonly struct VectorSource<S,SW>
        where S : unmanaged
        where SW : unmanaged, IVectorWidth
    {

    }

    public readonly struct VectorTarget<T,TW>
        where T : unmanaged
        where TW : unmanaged, IVectorWidth
    {

    }

    public abstract class VectorPipe<S,SW,T,TW> : IPipe<VectorSource<S,SW>, VectorTarget<T,TW>>
        where T : unmanaged
        where S : unmanaged
        where SW : unmanaged, IVectorWidth
        where TW : unmanaged, IVectorWidth
    {

        public virtual void Deposit(VectorSource<S,SW> src)
        {

        }

        public VectorTarget<T,TW> Next()
        {
            if(Next(out var next))
                return next;
            else
                return default;
        }

        public abstract bool Next(out VectorTarget<T,TW> dst);
    }

    public class VectorPipe128<T> : IPipe<Vector128<T>,Vector128<T>>
        where T : unmanaged
    {

        PipeBuffer<Vector128<T>> Buffer;

        public VectorPipe128()
        {
            Buffer = new PipeBuffer<Vector128<T>>();
        }

        [MethodImpl(Inline)]
        public virtual void Deposit(Vector128<T> src)
            => Buffer.Enqueue(src);

        [MethodImpl(Inline)]
        public Vector128<T> Next()
        {

           if(Next(out var v))
               return v;
           else
               return default;
        }

        public virtual bool Next(out Vector128<T> v)
        {
            if(Buffer.TryDequeue(out v))
                return true;
            else
            {
                v = default;
                return false;
            }
        }
    }
}