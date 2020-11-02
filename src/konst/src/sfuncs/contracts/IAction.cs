//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFxShape
    {
        [Free, SFx]
        public interface IAction<A> : IOperation
        {
            void Invoke(A a);
        }

        [Free, SFx]
        public interface IAction<A0,A1> : IOperation
        {
            void Invoke(A0 a0, A1 a1);
        }

        [Free, SFx]
        public interface IAction<A0,A1,A2> : IOperation
        {
            void Invoke(A0 a0, A1 a1, A2 a2);
        }
    }
}