//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static HK;
    using AsmSpecs;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Z0;

    public abstract class t_asm_explicit<E> : UnitTest<E>, IExplicitTest, ICaptureEventSink
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

            using var buffers = Context.Buffers(CaptureReceiptSink.Create(OnCaptureEvent));
            OnExecute(buffers);
        }

        protected abstract void OnExecute(in AsmBuffers buffers);

        protected IEnumerable<AsmCode> ArchivedCode(string catalog, string subject, OpIdentity id)
            => Context.CodeArchive(catalog,subject).Read(id);

        protected AsmFormatConfig DefaultAsmFormat
            => AsmFormatConfig.Default.WithoutFunctionTimestamp();

        protected IAsmHexWriter HexTestWriter([Caller] string test = null)
        {
            var dst = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Hex);    
            return  Context.HexWriter(dst);
        }


        protected IAsmFunctionWriter AsmTestWriter([Caller] string test = null)
        {
            var path = LogPaths.The.LogPath(LogArea.Test, FolderName.Define(GetType().Name), test, FileExtensions.Asm);    
            return Context.WithFormat(DefaultAsmFormat).AsmWriter(path);
        }


        public virtual void Accept(in CaptureEventData data)
        {
            
        }

        public virtual void Complete(in CaptureEventData data)
        {
            
        }
    }
}