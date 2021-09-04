//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;


    public static class XSvc
    {
        [Op]
        public static AsmCmdService AsmCmd(this IWfRuntime context)
            => AsmCmdService.create(context);

        [Op]
        public static TableLoaders TableLoaders(this IWfRuntime context)
            => Asm.TableLoaders.create(context);

        [Op]
        public static TableEmitters TableEmitters(this IWfRuntime context)
            => Asm.TableEmitters.create(context);
    }
}