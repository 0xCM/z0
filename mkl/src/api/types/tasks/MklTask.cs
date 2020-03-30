//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    
    public interface IMklTask : IDisposable
    {

    }
    public interface IMklTask<T> : IMklTask
        where T : unmanaged
    {
        
    }

    abstract class MklTask : IMklTask
    {
        protected IntPtr Pointer;

        public static implicit operator IntPtr(MklTask src)
            => src.Pointer;

        public IntPtr Handle
            => Pointer;

        protected MklTask(IntPtr Pointer)
            => this.Pointer = Pointer;

        protected MklTask()
        {
            Pointer = IntPtr.Zero;
        }
        public abstract void Dispose();
    }

    abstract class MklTask<T> : MklTask, IMklTask<T>
        where T : unmanaged
    {
                

        protected MklTask(IntPtr Pointer)
            : base(Pointer)
        {}

        protected MklTask()
        {
            
        }                
    }
}