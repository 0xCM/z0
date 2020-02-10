//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static HK;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public abstract class t_asm_explicit<E> : UnitTest<E>, IExplicitTest
        where E : t_asm_explicit<E>
    {
        protected IAsmContext Context;

        public t_asm_explicit()
        {
            Context = AsmContext.New(
                Designators.Data.Designated,
                Designators.GMath.Designated,
                Designators.Intrinsics.Designated,
                Designators.BitCore.Designated,
                Designators.BitGrids.Designated,
                Designators.Logix.Designated,
                Designators.CoreFunc.Designated,
                Designators.Root.Designated,
                Designators.DataCore.Designated
                );
                                    
        }
   
        public void Execute()
        {
            void OnCaptureEvent(in CaptureEventData data)
            {
                Trace($"{data.CaptureState}");
            }

            using var buffers = Context.Buffers(OnCaptureEvent);
            OnExecute(buffers);
        }

        protected abstract void OnExecute(in AsmBuffers buffers);

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        protected IAsmCodeWriter HexTestWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  Context.CodeWriter(dst);
        }

        protected IAsmFunctionWriter AsmTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);    
            return Context.WithFormat(DefaultAsmFormat).AsmWriter(path);
        }

    }
}