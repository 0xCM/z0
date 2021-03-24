//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Disposable<T> : IDisposable
        where T : IDisposable
    {
        readonly T Resource;

        bool Disposed;

        [MethodImpl(Inline)]
        public Disposable(T resource)
        {
            Resource = resource;
            Disposed = false;
        }

        public void Dispose()
        {
            Resource?.Dispose();
            Disposed = true;
        }

        public ref readonly T Access(out T resource)
        {
            resource = Resource;
            return ref resource;
        }

        public void Use(Action<T> user, bool dispose = true)
        {
            user(Resource);
            if(dispose)
            {
                Resource?.Dispose();
                Disposed = true;
            }
        }

        public static implicit operator Disposable<T>(T resource)
            => new Disposable<T>(resource);
    }
}