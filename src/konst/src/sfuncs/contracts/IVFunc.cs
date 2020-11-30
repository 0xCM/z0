//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct SFx
    {
        [Free, SFx]
        public interface IFunc128<T> : IFuncW<W128>
            where T : unmanaged
        {
            Vec128Kind<T> VKind
                => default;
        }

        [Free, SFx]
        public interface IFunc256<T> : IFuncW<W256>
            where T : unmanaged
        {
            Vec256Kind<T> VKind
                => default;
        }

        [Free, SFx]
        public interface IFunc512<T> : IFuncW<W512>
            where T : unmanaged
        {
            Vec512Kind<T> VKind
                => default;
        }
    }
}